namespace LAB6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namepokemon = new System.Windows.Forms.Label();
            this.buttonloadpokemonpikachu = new System.Windows.Forms.Button();
            this.buttonloadpokemoncinderace = new System.Windows.Forms.Button();
            this.buttonloadpokemongreninja = new System.Windows.Forms.Button();
            this.buttonloadpokemonzoroark = new System.Windows.Forms.Button();
            this.buttonloadpokemonlugia = new System.Windows.Forms.Button();
            this.buttonloadpokemonetenatus = new System.Windows.Forms.Button();
            this.picturepokemon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturepokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // namepokemon
            // 
            this.namepokemon.AutoSize = true;
            this.namepokemon.Location = new System.Drawing.Point(335, 34);
            this.namepokemon.Name = "namepokemon";
            this.namepokemon.Size = new System.Drawing.Size(41, 16);
            this.namepokemon.TabIndex = 1;
            this.namepokemon.Text = "name";
            // 
            // buttonloadpokemonpikachu
            // 
            this.buttonloadpokemonpikachu.Location = new System.Drawing.Point(51, 329);
            this.buttonloadpokemonpikachu.Name = "buttonloadpokemonpikachu";
            this.buttonloadpokemonpikachu.Size = new System.Drawing.Size(121, 23);
            this.buttonloadpokemonpikachu.TabIndex = 2;
            this.buttonloadpokemonpikachu.Text = "pikachu";
            this.buttonloadpokemonpikachu.UseVisualStyleBackColor = true;
            this.buttonloadpokemonpikachu.Click += new System.EventHandler(this.buttonloadpokemon_Click);
            // 
            // buttonloadpokemoncinderace
            // 
            this.buttonloadpokemoncinderace.Location = new System.Drawing.Point(178, 358);
            this.buttonloadpokemoncinderace.Name = "buttonloadpokemoncinderace";
            this.buttonloadpokemoncinderace.Size = new System.Drawing.Size(121, 23);
            this.buttonloadpokemoncinderace.TabIndex = 3;
            this.buttonloadpokemoncinderace.Text = "Cinderace";
            this.buttonloadpokemoncinderace.UseVisualStyleBackColor = true;
            this.buttonloadpokemoncinderace.Click += new System.EventHandler(this.buttonloadpokemoncinderace_Click);
            // 
            // buttonloadpokemongreninja
            // 
            this.buttonloadpokemongreninja.Location = new System.Drawing.Point(51, 358);
            this.buttonloadpokemongreninja.Name = "buttonloadpokemongreninja";
            this.buttonloadpokemongreninja.Size = new System.Drawing.Size(121, 23);
            this.buttonloadpokemongreninja.TabIndex = 4;
            this.buttonloadpokemongreninja.Text = "Greninja";
            this.buttonloadpokemongreninja.UseVisualStyleBackColor = true;
            this.buttonloadpokemongreninja.Click += new System.EventHandler(this.buttonloadpokemongreninja_Click);
            // 
            // buttonloadpokemonzoroark
            // 
            this.buttonloadpokemonzoroark.Location = new System.Drawing.Point(178, 329);
            this.buttonloadpokemonzoroark.Name = "buttonloadpokemonzoroark";
            this.buttonloadpokemonzoroark.Size = new System.Drawing.Size(121, 23);
            this.buttonloadpokemonzoroark.TabIndex = 5;
            this.buttonloadpokemonzoroark.Text = "Zoroark";
            this.buttonloadpokemonzoroark.UseVisualStyleBackColor = true;
            this.buttonloadpokemonzoroark.Click += new System.EventHandler(this.buttonloadpokemonzoroark_Click);
            // 
            // buttonloadpokemonlugia
            // 
            this.buttonloadpokemonlugia.Location = new System.Drawing.Point(51, 387);
            this.buttonloadpokemonlugia.Name = "buttonloadpokemonlugia";
            this.buttonloadpokemonlugia.Size = new System.Drawing.Size(121, 23);
            this.buttonloadpokemonlugia.TabIndex = 6;
            this.buttonloadpokemonlugia.Text = "Lugia";
            this.buttonloadpokemonlugia.UseVisualStyleBackColor = true;
            this.buttonloadpokemonlugia.Click += new System.EventHandler(this.buttonloadpokemonlugia_Click);
            // 
            // buttonloadpokemonetenatus
            // 
            this.buttonloadpokemonetenatus.Location = new System.Drawing.Point(178, 387);
            this.buttonloadpokemonetenatus.Name = "buttonloadpokemonetenatus";
            this.buttonloadpokemonetenatus.Size = new System.Drawing.Size(121, 23);
            this.buttonloadpokemonetenatus.TabIndex = 7;
            this.buttonloadpokemonetenatus.Text = "Eternatus";
            this.buttonloadpokemonetenatus.UseVisualStyleBackColor = true;
            this.buttonloadpokemonetenatus.Click += new System.EventHandler(this.buttonloadpokemonetenatus_Click);
            // 
            // picturepokemon
            // 
            this.picturepokemon.Location = new System.Drawing.Point(51, 12);
            this.picturepokemon.Name = "picturepokemon";
            this.picturepokemon.Size = new System.Drawing.Size(261, 269);
            this.picturepokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepokemon.TabIndex = 0;
            this.picturepokemon.TabStop = false;
            this.picturepokemon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "VS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Timcook";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB6.Properties.Resources.Timcook;
            this.pictureBox1.Location = new System.Drawing.Point(516, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonloadpokemonetenatus);
            this.Controls.Add(this.buttonloadpokemonlugia);
            this.Controls.Add(this.buttonloadpokemonzoroark);
            this.Controls.Add(this.buttonloadpokemongreninja);
            this.Controls.Add(this.buttonloadpokemoncinderace);
            this.Controls.Add(this.buttonloadpokemonpikachu);
            this.Controls.Add(this.namepokemon);
            this.Controls.Add(this.picturepokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturepokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturepokemon;
        private System.Windows.Forms.Label namepokemon;
        private System.Windows.Forms.Button buttonloadpokemonpikachu;
        private System.Windows.Forms.Button buttonloadpokemoncinderace;
        private System.Windows.Forms.Button buttonloadpokemongreninja;
        private System.Windows.Forms.Button buttonloadpokemonzoroark;
        private System.Windows.Forms.Button buttonloadpokemonlugia;
        private System.Windows.Forms.Button buttonloadpokemonetenatus;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

