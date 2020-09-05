using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HaloMCCPCSaveTransferTool
{
    /// <summary>
    /// Gets and holds in game name and description from map and game type files
    /// </summary>
    public class FileInfo
    {
        #region Fields
        /// <summary>
        /// In game name of file
        /// </summary>
        public string InGameName = "";
        /// <summary>
        /// In game description of file
        /// </summary>
        public string Description = "";
        /// <summary>
        /// Game file is from
        /// </summary>
        public enum Game
        {
            HaloReach,
            HaloCE,
            Halo2Classic,
            Halo2Anniversary,
            Halo3,
            Halo3ODST,
            Halo4
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Creates an instance from strings 
        /// </summary>
        /// <param name="inGameName">In game name</param>
        /// <param name="description">In game description</param>
        public FileInfo(string inGameName = "", string description = "")
        {
            InGameName = inGameName ?? "";
            Description = description ?? "";
        }
        /// <summary>
        /// Creates an instance from a file 
        /// </summary>
        /// <param name="file">The file to be read</param>
        /// <param name="game">The game the file is from</param>
        public FileInfo(string file, Game game)
        {
            FileInfo info = GetFileInfo(file, game);
            InGameName = info.InGameName;
            Description = info.Description;
        }
        #endregion
        #region Functions
        /// <summary>
        /// The name and description seperated by a new line character
        /// </summary>
        /// <returns>The name and description seperated by a new line character</returns>
        public override string ToString()
        {
            return InGameName + "\n" + Description;
        }
        /// <summary>
        /// Turns a byte array into a string 16 bit characters and removes any null characters
        /// </summary>
        /// <param name="bytes">Character bytes</param>
        /// <returns>String version of bytes as 16 bit characters without any null characters</returns>
        static string GetStringOf16BitCharacters(byte[] bytes)
        {
            string returnValue = "";
            char currentChar;
            //16 bit chars shouldn't have remainder but if so assume the bit at the start is a null byte
            for (int i = bytes.Length % 2 == 0 ? 0 : 1; i < bytes.Length; i += 2)
            {
                currentChar = BytesTo16BitChar(bytes[i], bytes[i + 1]);//get current char
                returnValue += currentChar == 0 ? "" : currentChar.ToString(); //add if not null
            }
            return returnValue;
        }
        /// <summary>
        /// Turns a byte array into a string of 8 bit characters without any null characters
        /// </summary>
        /// <param name="bytes">Character bytes</param>
        /// <returns>String version of bytes as 8 bit characters without any null characters</returns>
        static string GetStringOf8BitCharacters(byte[] bytes)
        {
            string returnValue = "";
            char currentChar;
            for (int i = 0; i < bytes.Length; i++)
            {
                currentChar = (char)bytes[i];//get current char
                returnValue += currentChar == 0 ? "" : currentChar.ToString(); //add if not null
            }
            return returnValue;
        }
        /// <summary>
        /// Gets in game name and description as an array of bytes from a byte array where the name and description are seperated by null bytes
        /// </summary>
        /// <param name="input">File as byte array</param>
        /// <param name="startingByte">Where the in game name starts</param>
        /// <param name="name">The array where the in game name will be stored</param>
        /// <param name="description">The array where the in game description will be stored</param>
        /// <param name="has16BitDescription">Is the description 16 byte characters?</param>
        /// <param name="maxBytesToParse">How many bytes the function should parse before returning incomplete</param>
        static void GetNameAndDescriptionBytes(byte[] input, int startingByte, out byte[] name, out byte[] description, bool has16BitDescription = true, int maxBytesToParse = 512)
        {
            int nullBytesInARow = 0;
            int stoppingByte = startingByte + maxBytesToParse;
            if (stoppingByte > input.Length) stoppingByte = input.Length;
            int endOfName = 0;
            int startOfDescription = 0;
            int endOfDescription = 0;
            name = new byte[0];
            description = new byte[0];
            for (int i = startingByte; i < stoppingByte; i++)
            {
                if (input[i] == 0) //null byte
                {
                    nullBytesInARow++;
                    if (nullBytesInARow == 2)//space between or end of name or description
                    {
                        if (endOfName == 0) //found end of name
                        {
                            endOfName = i;
                            name = input.Skip(startingByte).Take(endOfName - startingByte + 1).ToArray();
                        }
                        else if (startOfDescription != 0) //found end of description
                        {
                            endOfDescription = i;
                            description = input.Skip(startOfDescription).Take(endOfDescription - startOfDescription - 1).ToArray();
                            return;
                        }
                    }
                }
                else if (name.Length != 0 && startOfDescription == 0) //found start of description
                {
                    nullBytesInARow = 0;
                    startOfDescription = i;
                    if (has16BitDescription) startOfDescription--; //stored as 16 bit char so will usually need the null that came before if it's A-z or 0-9
                }
                else //non null byte
                {
                    nullBytesInARow = 0;
                }
            }
        }
        /// <summary>
        /// Gets in game name and description as an array of bytes from a byte array where the name and description are at specific points in the file
        /// </summary>
        /// <param name="input">File as byte array</param>
        /// <param name="nameStartByte">Where the in game name starts</param>
        /// <param name="name">The array where the in game name will be stored</param>
        /// <param name="descriptionStartByte">Where the in game description starts</param>
        /// <param name="description">The array where the in game description will be stored</param>
        /// <param name="maxBytesToParse">How many bytes the function should parse before returning incomplete</param>
        static void GetNameAndDescriptionBytes(byte[] input, int nameStartByte, out byte[] name, int descriptionStartByte, out byte[] description, int maxBytesToParse = 512)
        {
            int nullBytesInARow = 0;
            int stoppingByte = nameStartByte + maxBytesToParse;
            if (stoppingByte > input.Length) stoppingByte = input.Length;
            int endOfName = 0;
            name = new byte[0];
            for (int i = nameStartByte; i < stoppingByte; i++)
            {
                if (input[i] == 0) //null byte
                {
                    nullBytesInARow++;
                    if (nullBytesInARow >= 2)//space between or end of name or description
                    {
                        if (endOfName == 0) //found end of name
                        {
                            endOfName = i;
                            name = input.Skip(nameStartByte).Take(endOfName - nameStartByte - 1).ToArray();
                            break;
                        }
                    }
                }
                else //non null byte
                {
                    nullBytesInARow = 0;
                }
            }
            stoppingByte = descriptionStartByte + maxBytesToParse;
            if (stoppingByte > input.Length) stoppingByte = input.Length;
            nullBytesInARow = 0;
            int endOfDescription = 0;
            description = new byte[0];
            for (int i = descriptionStartByte; i < stoppingByte; i++)
            {
                if (input[i] == 0) //null byte
                {
                    nullBytesInARow++;
                    if (nullBytesInARow >= 2)//space between or end of name or description
                    {
                        endOfDescription = i;
                        description = input.Skip(descriptionStartByte).Take(endOfDescription - descriptionStartByte - 1).ToArray();
                        break;
                    }
                }
                else //non null byte
                {
                    nullBytesInARow = 0;
                }
            }
        }
        /// <summary>
        /// Safely gets a 16 bit character from 2 bytes
        /// </summary>
        /// <param name="byte1">First byte of character</param>
        /// <param name="byte2">Second byte of character</param>
        /// <returns>Character version of the two bytes</returns>
        static char BytesTo16BitChar(byte byte1, byte byte2)
        {
            try
            {
                return (char)((byte1 << 8) | byte2);
            }
            catch { return (char)0; }
        }
        /// <summary>
        /// Gets in game name and description as strings from a file
        /// </summary>
        /// <param name="file">File to be read</param>
        /// <param name="game">Game the file is from</param>
        /// <returns>Returns FileInfo class with in game name and description as strings. If the name and or description can't be read the strings will be empty</returns>
        static FileInfo GetFileInfo(string file, Game game)
        {
            FileInfo returnInfo = new FileInfo();
            if (file != null && File.Exists(file) && Path.GetExtension(file) == ".bin" || Path.GetExtension(file) == ".mvar")
            {
                byte[] fileBytes = File.ReadAllBytes(file);
                byte[] name = new byte[0];
                byte[] description = new byte[0];
                switch (game)
                {
                    case Game.HaloReach:
                        int offset = fileBytes[192] == 0 ? 1 : 0;
                        GetNameAndDescriptionBytes(fileBytes, 191 + offset, out name, 447 + offset, out description);
                        return new FileInfo(GetStringOf16BitCharacters(name), GetStringOf16BitCharacters(description));
                    case Game.HaloCE:
                        GetNameAndDescriptionBytes(fileBytes, 151, out name, 407, out description);
                        return new FileInfo(GetStringOf16BitCharacters(name), GetStringOf16BitCharacters(description));
                    case Game.Halo2Classic:
                        GetNameAndDescriptionBytes(fileBytes, 303, out name, 559, out description);
                        return new FileInfo(GetStringOf16BitCharacters(name), GetStringOf16BitCharacters(description));
                    case Game.Halo2Anniversary:
                        if (Path.GetExtension(file) == ".bin")
                        {
                            GetNameAndDescriptionBytes(fileBytes, 191, out name, 447, out description);
                            return new FileInfo(GetStringOf16BitCharacters(name), GetStringOf16BitCharacters(description));
                        }
                        else
                        {
                            //maps bit shifted 2 left. Description next to name
                            GetNameAndDescriptionBytes(fileBytes, 161, out name, out description);
                            BinaryArray binaryArray = new BinaryArray(name);
                            binaryArray.ShiftRight(2);
                            returnInfo.InGameName = GetStringOf16BitCharacters(binaryArray.CopyToByteArray());
                            binaryArray = new BinaryArray(description);
                            binaryArray.ShiftRight(2);
                            returnInfo.Description = GetStringOf16BitCharacters(binaryArray.CopyToByteArray());
                            return returnInfo;
                        }
                    case Game.Halo3:
                        //check if built in file
                        offset = 0;
                        string builtInTextCheck = "";
                        for (int i = 14; i < 25; i++)
                        {
                            builtInTextCheck += (char)fileBytes[i];
                        }
                        //check of built in map or game type
                        if (builtInTextCheck == "game var\0\0\0")
                        {
                            //abort cant read built in game var 
                            Console.WriteLine("Unable to obtain built in Halo 3 game type name and description. Path:" + file);
                            return new FileInfo("Unable to obtain game name", "Unable to obtain description");
                        }
                        else if (builtInTextCheck == "map variant")
                        {
                            //built in map var, add offset
                            offset = -188;
                        }
                        int startName = 336;
                        if (Path.GetExtension(file) == ".bin")
                        {
                            startName = 343;
                        }
                        if (fileBytes[startName + offset + 1] == 0) { offset++; } //check if info is shifted by 1 if so adjust offset
                        GetNameAndDescriptionBytes(fileBytes, startName + offset, out name, out description, false);
                        returnInfo = new FileInfo(GetStringOf16BitCharacters(name), GetStringOf8BitCharacters(description));
                        return returnInfo;
                    case Game.Halo3ODST:
                        //Not implemented yet
                        break;
                    case Game.Halo4:
                        GetNameAndDescriptionBytes(fileBytes, 192, out name, 448, out description);
                        return new FileInfo(GetStringOf16BitCharacters(name), GetStringOf16BitCharacters(description));
                }
            }
            return returnInfo;
        }
        #endregion
    }
}
