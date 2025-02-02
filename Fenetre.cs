using System;
using System.Drawing;
using System.Windows.Forms;

namespace aff
{
    public class Fenetre : Form
    {
        public static CheckBox graphMod;
        // private TerrainPanel terrainPanel;
        public Button save;
        public Button load;
        // public static ScorePanel scorePanel;

        // Ajout des champs vitesse et point
        private Label vitesseLabel;
        // public static TextBox nbr;

        public void initializeConsole()
        {
        }

        public Fenetre()
        {
            configurationExtension();
            configurationFenetre();
            addEcouteur();
        }

        public void addEcouteur()
        {
            // TerrainEcouteur terrainEcouteur = new TerrainEcouteur();
            // terrainPanel.MouseClick += terrainEcouteur.mouseClick;
            // graphMod.CheckedChanged += terrainEcouteur.graph_Mod;
            // save.Click += terrainEcouteur._save;
            // load.Click += terrainEcouteur._load;
        }

       

        public void configurationExtension()
        {
            // Configuration du CheckBox graphMod
            graphMod = new CheckBox
            {
                Text = "graph mod",
                Location = new Point(300, 20),
                Checked = false
            };
            save = new Button
            {
                Text = "Save",
                Location = new Point(450, 160),
                Width = 100,
                Height = 60,
            };
            load = new Button
            {
                Text = "Load",
                Location = new Point(450, 240),
                Width = 100,
                Height = 60,
            };

            // Configuration du Label et TextBox pour la vitesse
            // vitesseLabel = new Label
            // {
            //     Text = "Nbr:",
            //     Location = new Point(300, 60),
            //     Width = 50
            // };
            // nbr = new TextBox
            // {
            //     Location = new Point(350, 60),
            //     Width = 40,
            //     Text = "10"
            // };
        }

        private void configurationFenetre()
        {
            Text = "tsipika";
            Width = 1200;
            Height = 670;
            // terrainPanel = new TerrainPanel();

            // console = new MyConsole();
            // scorePanel = new ScorePanel();

            // this.Controls.Add(terrainPanel);
            // this.Controls.Add(scorePanel);
            this.Controls.Add(graphMod);
            this.Controls.Add(vitesseLabel); // Ajout du label
            this.Controls.Add(save);
            this.Controls.Add(load);
        }
    }
}
