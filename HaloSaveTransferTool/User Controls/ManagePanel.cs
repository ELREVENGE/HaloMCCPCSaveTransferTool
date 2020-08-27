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
            string halo2FileIgnoreList;
            string halo2AFileIgnoreList;
            string extention;
            string ignoreListDirectory = @"\Ignore Lists\";
            if (fileType == FileType.Map)
            {
                extention = "mvar";
                builtInDirectory = "map_variants";
                privateDirecory = "Map";
                reachFileIgnoreList = ignoreListDirectory + "HaloReachMapIgnoreList.txt";
                halo3FileIgnoreList = ignoreListDirectory + "Halo3MapIgnoreList.txt";
                halo2FileIgnoreList = "";
                halo2AFileIgnoreList = ignoreListDirectory + "Halo2AMapIgnoreList.txt";
            }
            else
            {
                extention = "bin";
                builtInDirectory = "game_variants";
                privateDirecory = "GameType";
                reachFileIgnoreList = ignoreListDirectory + "HaloReachGameTypeIgnoreList.txt";
                halo3FileIgnoreList = ignoreListDirectory + "Halo3GameTypeIgnoreList.txt";
                halo2FileIgnoreList = ignoreListDirectory + "Halo2GameTypeIgnoreList.txt";
                halo2AFileIgnoreList = ignoreListDirectory + "Halo2AGameTypeIgnoreList.txt";
            }
            ReachManageBuiltInGameFiles.Set("Halo: Reach", Properties.Settings.Default.BuiltInLocation + @"\haloreach\"+ builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + reachFileIgnoreList, ReachManagePrivateGameFiles);
            ReachManagePrivateGameFiles.Set("Halo: Reach", Properties.Settings.Default.PrivateLocation + @"\HaloReach\" + privateDirecory, extention, new List<string>(), ReachManageBuiltInGameFiles);
            if (fileType == FileType.Map)
            {
                //remove column for maps since there are no maps for halo 2 classic
                BuiltInTableLayoutPanel.RemoveColumnAt(1);
                PrivateTableLayoutPanel.RemoveColumnAt(1);
                //resize columns
                for (int i = 0; i < PrivateTableLayoutPanel.ColumnCount; i++)
                {
                    PrivateTableLayoutPanel.ColumnStyles[i].SizeType = SizeType.Percent;
                    PrivateTableLayoutPanel.ColumnStyles[i].Width = 33;
                }
                for (int i = 0; i < BuiltInTableLayoutPanel.ColumnCount; i++)
                {
                    BuiltInTableLayoutPanel.ColumnStyles[i].SizeType = SizeType.Percent;
                    BuiltInTableLayoutPanel.ColumnStyles[i].Width = 33;
                }
            }
            else if(fileType == FileType.GameType)
            {
                //gametypes for halo 2 classic
                Halo2ManageBuiltInGameFiles.Set("Halo 2", Properties.Settings.Default.BuiltInLocation + @"\halo2\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2FileIgnoreList, Halo2ManagePrivateGameFiles);
                Halo2ManagePrivateGameFiles.Set("Halo 2", Properties.Settings.Default.PrivateLocation + @"\Halo2\" + privateDirecory, extention, new List<string>(), Halo2ManageBuiltInGameFiles);
            }
            Halo2AManageBuiltInGameFiles.Set("Halo 2 Anniversary", Properties.Settings.Default.BuiltInLocation + @"\groundhog\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2AFileIgnoreList, Halo2AManagePrivateGameFiles);
            Halo2AManagePrivateGameFiles.Set("Halo 2 Anniversary", Properties.Settings.Default.PrivateLocation + @"\Halo2A\" + privateDirecory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2AFileIgnoreList, Halo2AManageBuiltInGameFiles);
            Halo3ManageBuiltInGameFiles.Set("Halo 3", Properties.Settings.Default.BuiltInLocation + @"\halo3\"+builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo3FileIgnoreList, Halo3ManagePrivateGameFiles);
            Halo3ManagePrivateGameFiles.Set("Halo 3", Properties.Settings.Default.PrivateLocation + @"\Halo3\"+privateDirecory, extention, new List<string>(), Halo3ManageBuiltInGameFiles);
        }
    }
}
