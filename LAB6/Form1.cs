using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonloadpokemon_Click(object sender, EventArgs e)
        {

            Pikachu pikachu = new Pikachu();

            namepokemon.Text = pikachu.Outputname();
            //add pic
            picturepokemon.Image = LAB6.Properties.Resources.pikachu;
        }

        private void buttonloadpokemongreninja_Click(object sender, EventArgs e)
        {
            Greninja greninja = new Greninja();

            namepokemon.Text = greninja.Outputname();
            //add pic
            picturepokemon.Image=LAB6.Properties.Resources.Greninja;

        }

        private void buttonloadpokemonlugia_Click(object sender, EventArgs e)
        {
            Lugia lugia = new Lugia();

            namepokemon.Text= lugia.Outputname();
            //add pic
            picturepokemon.Image = LAB6.Properties.Resources.Lugia;
        }

        private void buttonloadpokemonzoroark_Click(object sender, EventArgs e)
        {
            Zoroark zoraark = new Zoroark();

            namepokemon.Text = zoraark.Outputname();
            //add pic
            picturepokemon.Image = LAB6.Properties.Resources.Zoroark;

        }

        private void buttonloadpokemoncinderace_Click(object sender, EventArgs e)
        {
            Cinderace cinderace = new Cinderace();

            namepokemon.Text = cinderace.Outputname();
            //add pic
            picturepokemon.Image = LAB6.Properties.Resources.Cinderace;
        }

        private void buttonloadpokemonetenatus_Click(object sender, EventArgs e)
        {
            Eternatus eternatus = new Eternatus();  

            namepokemon.Text = eternatus.Outputname();
            //add pic
            picturepokemon.Image = LAB6.Properties.Resources.Eternatus;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
