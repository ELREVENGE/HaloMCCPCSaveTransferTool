using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloMCCPCSaveTransferTool
{
    public partial class ManagePanel : UserControl
    {
        public enum FileType
        {
            Map,
            GameType
        }
        public ManagePanel()
        {
            InitializeComponent();
        }
        public void UpdateLists()
        {
            ReachManageBuiltInGameFiles.UpdateList();
            ReachManagePrivateGameFiles.UpdateList();
            Halo3ManageBuiltInGameFiles.UpdateList();
            Halo3ManagePrivateGameFiles.UpdateList();
        }
        public void Set(FileType fileType)
        {
            string builtInDirectory;
            string privateDirecory;
            string reachFileIgnoreList;
            string halo3FileIgnoreList;
            string extention;
            if (fileType == FileType.Map)
            {
                extention = "mvar";
                builtInDirectory = "map_variants";
                privateDirecory = "Map";
                reachFileIgnoreList = "HaloReachMapIgnoreList.txt";
                halo3FileIgnoreList = "Halo3MapIgnoreList.txt";
            }
            else
            {
                extention = "bin";
                builtInDirectory = "game_variants";
                privateDirecory = "GameType";
                reachFileIgnoreList = "HaloReachGameTypeIgnoreList.txt";
                halo3FileIgnoreList = "Halo3GameTypeIgnoreList.txt";
            }
            ReachManageBuiltInGameFiles.Set("Halo: Reach", Properties.Settings.Default.BuiltInLocation + @"\haloreach\"+ builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + reachFileIgnoreList, ReachManagePrivateGameFiles);
            Halo3ManageBuiltInGameFiles.Set("Halo 3", Properties.Settings.Default.BuiltInLocation + @"\halo3\"+builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo3FileIgnoreList, Halo3ManagePrivateGameFiles);
            ReachManagePrivateGameFiles.Set("Halo: Reach", Properties.Settings.Default.PrivateLocation + @"\HaloReach\"+privateDirecory, extention, new List<string>(), ReachManageBuiltInGameFiles);
            Halo3ManagePrivateGameFiles.Set("Halo 3", Properties.Settings.Default.PrivateLocation + @"\Halo3\"+privateDirecory, extention, new List<string>(), Halo3ManageBuiltInGameFiles);
        }
    }
}
