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
        ManageGameFiles HaloCEManageBuiltInGameFiles;
        ManageGameFiles Halo2ManageBuiltInGameFiles;
        ManageGameFiles Halo2AManageBuiltInGameFiles;
        ManageGameFiles Halo3ManageBuiltInGameFiles;
        ManageGameFiles ReachManageBuiltInGameFiles;
        ManageGameFiles HaloCEManagePrivateGameFiles;
        ManageGameFiles Halo2ManagePrivateGameFiles;
        ManageGameFiles Halo2AManagePrivateGameFiles;
        ManageGameFiles Halo3ManagePrivateGameFiles;
        ManageGameFiles ReachManagePrivateGameFiles;
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
            string haloCEFileIgnoreList;
            string halo3FileIgnoreList;
            string halo2FileIgnoreList;
            string halo2AFileIgnoreList;
            string extention;
            string ignoreListDirectory = @"\Ignore Lists\";
            Halo2AManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            Halo3ManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            ReachManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            Halo2AManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            Halo3ManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            ReachManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            if (fileType == FileType.Map)
            {
                extention = "mvar";
                builtInDirectory = "map_variants";
                privateDirecory = "Map";
                reachFileIgnoreList = ignoreListDirectory + "HaloReachMapIgnoreList.txt";
                haloCEFileIgnoreList = "";
                halo3FileIgnoreList = ignoreListDirectory + "Halo3MapIgnoreList.txt";
                halo2FileIgnoreList = "";
                halo2AFileIgnoreList = ignoreListDirectory + "Halo2AMapIgnoreList.txt";
            }
            else
            {
                HaloCEManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
                Halo2ManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
                HaloCEManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
                Halo2ManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
                extention = "bin";
                builtInDirectory = "game_variants";
                privateDirecory = "GameType";
                reachFileIgnoreList = ignoreListDirectory + "HaloReachGameTypeIgnoreList.txt";
                haloCEFileIgnoreList = ignoreListDirectory + "HaloCEGameTypeIgnoreList.txt";
                halo3FileIgnoreList = ignoreListDirectory + "Halo3GameTypeIgnoreList.txt";
                halo2FileIgnoreList = ignoreListDirectory + "Halo2GameTypeIgnoreList.txt";
                halo2AFileIgnoreList = ignoreListDirectory + "Halo2AGameTypeIgnoreList.txt";
            }
            ReachManageBuiltInGameFiles.Set("Halo: Reach", Properties.Settings.Default.BuiltInLocation + @"\haloreach\"+ builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + reachFileIgnoreList, ReachManagePrivateGameFiles);
            ReachManagePrivateGameFiles.Set("Halo: Reach", Properties.Settings.Default.PrivateLocation + @"\HaloReach\" + privateDirecory, extention, new List<string>(), ReachManageBuiltInGameFiles);
            if (fileType == FileType.Map)
            {
                //no column for halo 2 classic or CE maps since they only have gametypes
                BuiltInTableLayoutPanel.Controls.Add(ReachManageBuiltInGameFiles, 0, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo2AManageBuiltInGameFiles, 1, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo3ManageBuiltInGameFiles, 2, 0);

                PrivateTableLayoutPanel.Controls.Add(ReachManagePrivateGameFiles, 0, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo2AManagePrivateGameFiles, 1, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo3ManagePrivateGameFiles, 2, 0);

            }
            else if(fileType == FileType.GameType)
            {
                //game types for halo CE
                HaloCEManageBuiltInGameFiles.Set("Halo: CE", Properties.Settings.Default.BuiltInLocation + @"\halo1\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + haloCEFileIgnoreList, HaloCEManagePrivateGameFiles);
                HaloCEManagePrivateGameFiles.Set("Halo: CE", Properties.Settings.Default.PrivateLocation + @"\Halo1\" + privateDirecory, extention, new List<string>(), HaloCEManageBuiltInGameFiles);
                //gametypes for halo 2 classic
                Halo2ManageBuiltInGameFiles.Set("Halo 2: Classic", Properties.Settings.Default.BuiltInLocation + @"\halo2\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2FileIgnoreList, Halo2ManagePrivateGameFiles);
                Halo2ManagePrivateGameFiles.Set("Halo 2: Classic", Properties.Settings.Default.PrivateLocation + @"\Halo2\" + privateDirecory, extention, new List<string>(), Halo2ManageBuiltInGameFiles);
                //Extention method for removing columns was causing issues so I'm adding columns here
                //Set table
                BuiltInTableLayoutPanel.ColumnCount = 5;
                PrivateTableLayoutPanel.ColumnCount = 5;
                for (int i = 0; i < PrivateTableLayoutPanel.ColumnCount; i++)
                {
                    PrivateTableLayoutPanel.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, 20);
                }
                for (int i = 0; i < BuiltInTableLayoutPanel.ColumnCount; i++)
                {
                    BuiltInTableLayoutPanel.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, 20);
                }
                BuiltInTableLayoutPanel.Controls.Add(ReachManageBuiltInGameFiles, 0, 0);
                BuiltInTableLayoutPanel.Controls.Add(HaloCEManageBuiltInGameFiles, 1, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo2ManageBuiltInGameFiles, 2, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo2AManageBuiltInGameFiles, 3, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo3ManageBuiltInGameFiles, 4, 0);

                PrivateTableLayoutPanel.Controls.Add(ReachManagePrivateGameFiles, 0, 0);
                PrivateTableLayoutPanel.Controls.Add(HaloCEManagePrivateGameFiles, 1, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo2ManagePrivateGameFiles, 2, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo2AManagePrivateGameFiles, 3, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo3ManagePrivateGameFiles, 4, 0);
            }
            Halo2AManageBuiltInGameFiles.Set("Halo 2: Anniversary", Properties.Settings.Default.BuiltInLocation + @"\groundhog\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2AFileIgnoreList, Halo2AManagePrivateGameFiles);
            Halo2AManagePrivateGameFiles.Set("Halo 2: Anniversary", Properties.Settings.Default.PrivateLocation + @"\Halo2A\" + privateDirecory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2AFileIgnoreList, Halo2AManageBuiltInGameFiles);
            Halo3ManageBuiltInGameFiles.Set("Halo 3", Properties.Settings.Default.BuiltInLocation + @"\halo3\"+builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo3FileIgnoreList, Halo3ManagePrivateGameFiles);
            Halo3ManagePrivateGameFiles.Set("Halo 3", Properties.Settings.Default.PrivateLocation + @"\Halo3\"+privateDirecory, extention, new List<string>(), Halo3ManageBuiltInGameFiles);
        }
    }
}
