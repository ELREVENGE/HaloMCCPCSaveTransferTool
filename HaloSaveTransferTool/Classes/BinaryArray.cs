using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HaloMCCPCSaveTransferTool
{
     /// <summary>
    /// Wrapper class for bit array that holds bits from bytes from most significant to least significant (reverse of BitArray) which allows easy bit shifting
    /// </summary>
    public class BinaryArray
    {
        /// <summary>
        /// The BitArray that holds all the bits
        /// </summary>
        BitArray bitArray;
        /// <summary>
        /// Create a binary array from byte array 
        /// </summary>
        /// <param name="bytes">Bytes to be turned into an array</param>
        public BinaryArray(byte[] bytes)
        {
            FromByteArray(bytes);
        }
        /// <summary>
        /// Set bits from a array of bytes
        /// </summary>
        /// <param name="bytes">The byte array to be set from</param>
        public void FromByteArray(byte[] bytes)
        {
            if (bytes != null && bytes.Length > 0)
            {
                byte[] singleByte = new byte[1] { bytes[0] };
                BitArray singleByteArray;
                List<bool> bits = new List<bool>();
                for (int i = 0; i < bytes.Length; i++)
                {
                    singleByte[0] = bytes[i];
                    singleByteArray = new BitArray(singleByte);
                    for (int j = 7; j >= 0; j--)
                    {
                        bits.Add(singleByteArray[j]);
                    }
                }
                bitArray = new BitArray(bits.Count);
                for (int i = 0; i < bits.Count; i++)
                {
                    bitArray[i] = bits[i];
                }
            }
        }
        /// <summary>
        /// Copy bits to a byte array
        /// </summary>
        /// <returns>Bits as a byte array</returns>
        public byte[] CopyToByteArray()
        {
            if (bitArray.Count % 8 != 0) throw new Exception("Amount of bits in BitArray is not evenly divisable by 8 and can't be turned into bytes properly");
            if (bitArray.Count == 0) return new byte[0]; // if count is 0 the exception will not be thrown but the rest of the function shouldn't be preformed
            byte[] returnValue = new byte[bitArray.Count / 8];
            int currentByte;
            int currentBit;
            for (int i = 0; i < returnValue.Length; i++)
            {
                currentByte = 0;
                for (int j = 0; j < 8; j++)
                {
                    currentByte = currentByte << 1; //does nothing when j = 0 otherwise shifts bits left and sets last bit to 0
                    currentBit = bitArray[i * 8 + j] ? 1 : 0; //get bit from array
                    currentByte = currentByte | currentBit; //set least significant bit
                }
                returnValue[i] = Convert.ToByte(currentByte); //add completed byte to the return value array
            }
            return returnValue;
        }
        /// <summary>
        /// Gets bit at a specified index as a bool
        /// </summary>
        /// <param name="index">Index of byte</param>
        /// <returns>Bit as a bool</returns>
        public bool this[int index]
        {
            get => bitArray[index];
            set => bitArray[index] = value;
        }
        /// <summary>
        /// Shifts bits right by a specified amount
        /// </summary>
        /// <param name="shiftAmount">How much to shift</param>
        /// <param name="replaceWith">What to set on the left side of the array</param>
        /// <returns>Overflow bits as a bool array</returns>
        public bool[] ShiftRight(int shiftAmount, bool replaceWith = false)
        {
            int bitArrayCount = bitArray.Count;
            List<bool> returnValue = new List<bool>(); // holds overflow data
            if (shiftAmount == 0) return returnValue.ToArray(); // No shift
            else if (shiftAmount >= bitArrayCount) // Shift all the bits out
            {
                for (int i = 0; i < bitArrayCount; i++)
                {
                    returnValue.Add(bitArray[i]);
                    bitArray[i] = replaceWith;
                }
            }
            else //shift some bits 
            {
                for (int i = 0; i < shiftAmount; i++)
                {
                    //collect overflow data
                    returnValue.Add(bitArray[bitArrayCount - shiftAmount + i]);
                }
                for (int i = bitArrayCount - shiftAmount - 1; i >= 0; i--)
                {
                    //shift bits
                    bitArray[i + shiftAmount] = bitArray[i];
                }
                for (int i = 0; i < shiftAmount; i++)
                {
                    //replace bits at the start
                    bitArray[i] = replaceWith;
                }
            }
            return returnValue.ToArray();
        }
        /// <summary>
        /// Shifts bits left by a specified amount
        /// </summary>
        /// <param name="shiftAmount">How much to shift</param>
        /// <param name="replaceWith">What to set on the right side of the array</param>
        /// <returns>Overflow bits as a bool array</returns>
        public bool[] ShiftLeft(int shiftAmount, bool replaceWith = false)
        {
            int bitArrayCount = bitArray.Count;
            List<bool> returnValue = new List<bool>(); // holds overflow data
            if (shiftAmount == 0) return returnValue.ToArray(); // No shift
            else if (shiftAmount >= bitArrayCount) // Shift all the bits out
            {
                for (int i = 0; i < bitArrayCount; i++)
                {
                    returnValue.Add(bitArray[i]);
                    bitArray[i] = replaceWith;
                }
            }
            else //shift some bits 
            {
                for (int i = 0; i < shiftAmount; i++)
                {
                    //collect overflow data
                    returnValue.Add(bitArray[i]);
                }
                for (int i = shiftAmount; i < bitArrayCount; i++)
                {
                    //shift bits
                    bitArray[i - shiftAmount] = bitArray[i];
                }
                for (int i = bitArrayCount - shiftAmount; i < bitArrayCount; i++)
                {
                    //replace bits at the end
                    bitArray[i] = replaceWith;
                }
            }
            return returnValue.ToArray();
        }
        /// <summary>
        /// Gets binary representation of array as a string of 1s and 0s with a space between each byte
        /// </summary>
        /// <returns>Returns array as a string of 1s and 0s with a space between each byte</returns>
        public override string ToString()
        {
            string bitsString = "";
            for (int i = 0, bits = 0; i < bitArray.Count; i++)
            {
                bitsString += bitArray[i] ? "1" : "0";
                bits++;
                if (bits >= 8)
                {
                    bits = 0;
                    bitsString += " ";
                }
            }
            return bitsString;
        }
    }
}
