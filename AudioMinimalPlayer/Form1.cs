using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace AudioMinimalPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer sp = new SoundPlayer("audiofila.wav");

        private void Form1_Load(object sender, EventArgs e)
        {
            sp.Load();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            sp.Stop();
            sp.Play();
            
        }
    }
}
