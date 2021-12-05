﻿using System;
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
        #region Fields
        ManageGameFiles HaloCEManageBuiltInGameFiles;
        ManageGameFiles Halo2ManageBuiltInGameFiles;
        ManageGameFiles Halo2AManageBuiltInGameFiles;
        ManageGameFiles Halo3ManageBuiltInGameFiles;
        ManageGameFiles ReachManageBuiltInGameFiles;
        ManageGameFiles Halo4ManageBuiltInGameFiles;

        ManageGameFiles HaloCEManagePrivateGameFiles;
        ManageGameFiles Halo2ManagePrivateGameFiles;
        ManageGameFiles Halo2AManagePrivateGameFiles;
        ManageGameFiles Halo3ManagePrivateGameFiles;
        ManageGameFiles ReachManagePrivateGameFiles;
        ManageGameFiles Halo4ManagePrivateGameFiles;

        static string reachFileIgnoreList;
        static string haloCEFileIgnoreList;
        static string halo3FileIgnoreList;
        static string halo2FileIgnoreList;
        static string halo2AFileIgnoreList;
        static string halo4FileIgnoreList;
        static string ignoreListDirectory = @"\Ignore Lists\";
        string extention;
        FileType Type;
        #endregion
        #region Init and setup
        public ManagePanel()
        {
            InitializeComponent();
            SettingsControl.BuiltInChanged += SetAndUpdateBuiltInLists;
            SettingsControl.PrivateChanged += SetAndUpdatePrivateLists;
        }
        public void SetUp(FileType fileType)
        {
            Type = fileType;
            string builtInDirectory;
            string privateDirectory;
            int columnCount;

            Halo2AManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            Halo3ManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            ReachManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            Halo4ManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };

            Halo2AManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            Halo3ManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            ReachManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            Halo4ManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
            if (Type == FileType.Map)
            {
                extention = "mvar";
                builtInDirectory = "map_variants";
                privateDirectory = "Map";
                reachFileIgnoreList = ignoreListDirectory + "HaloReachMapIgnoreList.txt";
                haloCEFileIgnoreList = "";
                halo3FileIgnoreList = ignoreListDirectory + "Halo3MapIgnoreList.txt";
                halo2FileIgnoreList = "";
                halo2AFileIgnoreList = ignoreListDirectory + "Halo2AMapIgnoreList.txt";
                halo4FileIgnoreList = ignoreListDirectory + "Halo4MapIgnoreList.txt";
                //no column for halo 2 classic or CE maps since they only have gametypes
                BuiltInTableLayoutPanel.Controls.Add(ReachManageBuiltInGameFiles, 0, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo2AManageBuiltInGameFiles, 1, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo3ManageBuiltInGameFiles, 2, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo4ManageBuiltInGameFiles, 3, 0);

                PrivateTableLayoutPanel.Controls.Add(ReachManagePrivateGameFiles, 0, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo2AManagePrivateGameFiles, 1, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo3ManagePrivateGameFiles, 2, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo4ManagePrivateGameFiles, 3, 0);
                columnCount = 4;
                //float size = 100 / 4;
                //for (int i = 0; i < PrivateTableLayoutPanel.ColumnCount; i++)
                //{
                //    PrivateTableLayoutPanel.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, size);
                //}
                //for (int i = 0; i < BuiltInTableLayoutPanel.ColumnCount; i++)
                //{
                //    BuiltInTableLayoutPanel.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, size);
                //}
            }
            else
            {
                HaloCEManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
                Halo2ManageBuiltInGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
                HaloCEManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
                Halo2ManagePrivateGameFiles = new ManageGameFiles() { Dock = DockStyle.Fill };
                extention = "bin";
                builtInDirectory = "game_variants";
                privateDirectory = "GameType";
                reachFileIgnoreList = ignoreListDirectory + "HaloReachGameTypeIgnoreList.txt";
                haloCEFileIgnoreList = ignoreListDirectory + "HaloCEGameTypeIgnoreList.txt";
                halo3FileIgnoreList = ignoreListDirectory + "Halo3GameTypeIgnoreList.txt";
                halo2FileIgnoreList = ignoreListDirectory + "Halo2GameTypeIgnoreList.txt";
                halo2AFileIgnoreList = ignoreListDirectory + "Halo2AGameTypeIgnoreList.txt";
                halo4FileIgnoreList = ignoreListDirectory + "Halo4GameTypeIgnoreList.txt";
                //game types for halo CE
                HaloCEManageBuiltInGameFiles.Set(FileInfo.Game.HaloCE, Properties.Settings.Default.BuiltInLocation + @"\halo1\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + haloCEFileIgnoreList, HaloCEManagePrivateGameFiles);
                HaloCEManagePrivateGameFiles.Set(FileInfo.Game.HaloCE, Properties.Settings.Default.PrivateLocation + @"\Halo1\" + privateDirectory, extention, new List<string>(), HaloCEManageBuiltInGameFiles);
                //gametypes for halo 2 classic
                Halo2ManageBuiltInGameFiles.Set(FileInfo.Game.Halo2Classic, Properties.Settings.Default.BuiltInLocation + @"\halo2\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2FileIgnoreList, Halo2ManagePrivateGameFiles);
                Halo2ManagePrivateGameFiles.Set(FileInfo.Game.Halo2Classic, Properties.Settings.Default.PrivateLocation + @"\Halo2\" + privateDirectory, extention, new List<string>(), Halo2ManageBuiltInGameFiles);
                //Extention method for removing columns was causing issues so I'm adding columns here
                //Set table
                columnCount = 6;
                //BuiltInTableLayoutPanel.ColumnCount = columnCount;
                //PrivateTableLayoutPanel.ColumnCount = columnCount;
                //float size = 100 / columnCount;
                //for (int i = 0; i < PrivateTableLayoutPanel.ColumnCount; i++)
                //{
                //    PrivateTableLayoutPanel.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, size);
                //}
                //for (int i = 0; i < BuiltInTableLayoutPanel.ColumnCount; i++)
                //{
                //    BuiltInTableLayoutPanel.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, size);
                //}
                BuiltInTableLayoutPanel.Controls.Add(ReachManageBuiltInGameFiles, 0, 0);
                BuiltInTableLayoutPanel.Controls.Add(HaloCEManageBuiltInGameFiles, 1, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo2ManageBuiltInGameFiles, 2, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo2AManageBuiltInGameFiles, 3, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo3ManageBuiltInGameFiles, 4, 0);
                BuiltInTableLayoutPanel.Controls.Add(Halo4ManageBuiltInGameFiles, 5, 0);

                PrivateTableLayoutPanel.Controls.Add(ReachManagePrivateGameFiles, 0, 0);
                PrivateTableLayoutPanel.Controls.Add(HaloCEManagePrivateGameFiles, 1, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo2ManagePrivateGameFiles, 2, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo2AManagePrivateGameFiles, 3, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo3ManagePrivateGameFiles, 4, 0);
                PrivateTableLayoutPanel.Controls.Add(Halo4ManagePrivateGameFiles, 5, 0);
            }
            BuiltInTableLayoutPanel.ColumnCount = columnCount;
            BuiltInTableLayoutPanel.ColumnStyles.Clear();
            PrivateTableLayoutPanel.ColumnCount = columnCount;
            PrivateTableLayoutPanel.ColumnStyles.Clear();
            float size = 100 / columnCount;
            for (int i = 0; i < PrivateTableLayoutPanel.ColumnCount; i++)
            {
                PrivateTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, size));
            }
            for (int i = 0; i < BuiltInTableLayoutPanel.ColumnCount; i++)
            {
                BuiltInTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, size));
            }
            ReachManageBuiltInGameFiles.Set(FileInfo.Game.HaloReach, Properties.Settings.Default.BuiltInLocation + @"\haloreach\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + reachFileIgnoreList, ReachManagePrivateGameFiles);
            ReachManagePrivateGameFiles.Set(FileInfo.Game.HaloReach, Properties.Settings.Default.PrivateLocation + @"\HaloReach\" + privateDirectory, extention, new List<string>(), ReachManageBuiltInGameFiles);
            Halo2AManageBuiltInGameFiles.Set(FileInfo.Game.Halo2Anniversary, Properties.Settings.Default.BuiltInLocation + @"\groundhog\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2AFileIgnoreList, Halo2AManagePrivateGameFiles);
            Halo2AManagePrivateGameFiles.Set(FileInfo.Game.Halo2Anniversary, Properties.Settings.Default.PrivateLocation + @"\Halo2A\" + privateDirectory, extention, new List<string>(), Halo2AManageBuiltInGameFiles);
            Halo3ManageBuiltInGameFiles.Set(FileInfo.Game.Halo3, Properties.Settings.Default.BuiltInLocation + @"\halo3\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo3FileIgnoreList, Halo3ManagePrivateGameFiles);
            Halo3ManagePrivateGameFiles.Set(FileInfo.Game.Halo3, Properties.Settings.Default.PrivateLocation + @"\Halo3\" + privateDirectory, extention, new List<string>(), Halo3ManageBuiltInGameFiles);
            Halo4ManageBuiltInGameFiles.Set(FileInfo.Game.Halo4, Properties.Settings.Default.BuiltInLocation + @"\halo4\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo4FileIgnoreList, Halo4ManagePrivateGameFiles);
            Halo4ManagePrivateGameFiles.Set(FileInfo.Game.Halo4, Properties.Settings.Default.PrivateLocation + @"\Halo4\" + privateDirectory, extention, new List<string>(), Halo4ManageBuiltInGameFiles);

        }
        #endregion
        #region Update
        void UpdateList(ManageGameFiles list)
        {
            if (list != null) list.UpdateList();
        }
        public void SetAndUpdateBuiltInLists()
        {
            string builtInDirectory;
            if (Type == FileType.Map)
            {
                extention = "mvar";
                builtInDirectory = "map_variants";
            }
            else
            {
                extention = "bin";
                builtInDirectory = "game_variants";
                //game types for halo CE
                HaloCEManageBuiltInGameFiles.Set(FileInfo.Game.HaloCE, Properties.Settings.Default.BuiltInLocation + @"\halo1\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + haloCEFileIgnoreList, HaloCEManagePrivateGameFiles);
                //gametypes for halo 2 classic
                Halo2ManageBuiltInGameFiles.Set(FileInfo.Game.Halo2Classic, Properties.Settings.Default.BuiltInLocation + @"\halo2\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2FileIgnoreList, Halo2ManagePrivateGameFiles);
            }
            ReachManageBuiltInGameFiles.Set(FileInfo.Game.HaloReach, Properties.Settings.Default.BuiltInLocation + @"\haloreach\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + reachFileIgnoreList, ReachManagePrivateGameFiles);
            Halo2AManageBuiltInGameFiles.Set(FileInfo.Game.Halo2Anniversary, Properties.Settings.Default.BuiltInLocation + @"\groundhog\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo2AFileIgnoreList, Halo2AManagePrivateGameFiles);
            Halo3ManageBuiltInGameFiles.Set(FileInfo.Game.Halo3, Properties.Settings.Default.BuiltInLocation + @"\halo3\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo3FileIgnoreList, Halo3ManagePrivateGameFiles);
            Halo4ManageBuiltInGameFiles.Set(FileInfo.Game.Halo3, Properties.Settings.Default.BuiltInLocation + @"\halo4\" + builtInDirectory, extention, AppDomain.CurrentDomain.BaseDirectory + halo4FileIgnoreList, Halo4ManagePrivateGameFiles);
        }
        public void SetAndUpdatePrivateLists()
        {
            string privateDirectory;
            if (Type == FileType.Map)
            {
                extention = "mvar";
                privateDirectory = "Map";
            }
            else
            {
                extention = "bin";
                privateDirectory = "GameType";
                //game types for halo CE
                HaloCEManagePrivateGameFiles.Set(FileInfo.Game.HaloCE, Properties.Settings.Default.PrivateLocation + @"\Halo1\" + privateDirectory, extention, new List<string>(), HaloCEManageBuiltInGameFiles);
                //gametypes for halo 2 classic
                Halo2ManagePrivateGameFiles.Set(FileInfo.Game.Halo2Classic, Properties.Settings.Default.PrivateLocation + @"\Halo2\" + privateDirectory, extention, new List<string>(), Halo2ManageBuiltInGameFiles);
            }
            ReachManagePrivateGameFiles.Set(FileInfo.Game.HaloReach, Properties.Settings.Default.PrivateLocation + @"\HaloReach\" + privateDirectory, extention, new List<string>(), ReachManageBuiltInGameFiles);
            Halo2AManagePrivateGameFiles.Set(FileInfo.Game.Halo2Anniversary, Properties.Settings.Default.PrivateLocation + @"\Halo2A\" + privateDirectory, extention, new List<string>(), Halo2AManageBuiltInGameFiles);
            Halo3ManagePrivateGameFiles.Set(FileInfo.Game.Halo3, Properties.Settings.Default.PrivateLocation + @"\Halo3\" + privateDirectory, extention, new List<string>(), Halo3ManageBuiltInGameFiles);
            Halo4ManagePrivateGameFiles.Set(FileInfo.Game.Halo3, Properties.Settings.Default.PrivateLocation + @"\Halo4\" + privateDirectory, extention, new List<string>(), Halo4ManageBuiltInGameFiles);
        }
        public void UpdateLists()
        {
            UpdateList(HaloCEManagePrivateGameFiles);
            UpdateList(Halo2ManagePrivateGameFiles);
            UpdateList(Halo2AManagePrivateGameFiles);
            UpdateList(Halo3ManagePrivateGameFiles);
            UpdateList(ReachManagePrivateGameFiles);
            UpdateList(Halo4ManagePrivateGameFiles);

            UpdateList(HaloCEManageBuiltInGameFiles);
            UpdateList(Halo2ManageBuiltInGameFiles);
            UpdateList(Halo2AManageBuiltInGameFiles);
            UpdateList(Halo3ManageBuiltInGameFiles);
            UpdateList(ReachManageBuiltInGameFiles);
            UpdateList(Halo4ManageBuiltInGameFiles);
        }
        #endregion

    }
}
