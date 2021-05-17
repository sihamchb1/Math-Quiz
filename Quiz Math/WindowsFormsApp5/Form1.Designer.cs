
namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PlusLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlusRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.Difference = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.MinusRightLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MinusLeftLabel = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TimesRightLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TimesLeftLabel = new System.Windows.Forms.Label();
            this.Quotient = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.DevidedRightLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DevidedLeftLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(281, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(200, 30);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // PlusLeftLabel
            // 
            this.PlusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusLeftLabel.Location = new System.Drawing.Point(25, 70);
            this.PlusLeftLabel.Name = "PlusLeftLabel";
            this.PlusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusLeftLabel.TabIndex = 2;
            this.PlusLeftLabel.Text = "?";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "+";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PlusRightLabel
            // 
            this.PlusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusRightLabel.Location = new System.Drawing.Point(181, 70);
            this.PlusRightLabel.Name = "PlusRightLabel";
            this.PlusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusRightLabel.TabIndex = 4;
            this.PlusRightLabel.Text = "?";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "=";
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(325, 80);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(147, 20);
            this.Sum.TabIndex = 2;
            this.Sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // Difference
            // 
            this.Difference.Location = new System.Drawing.Point(325, 119);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(147, 20);
            this.Difference.TabIndex = 3;
            this.Difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 10;
            this.label6.Text = "=";
            // 
            // MinusRightLabel
            // 
            this.MinusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusRightLabel.Location = new System.Drawing.Point(181, 109);
            this.MinusRightLabel.Name = "MinusRightLabel";
            this.MinusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusRightLabel.TabIndex = 9;
            this.MinusRightLabel.Text = "?";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 8;
            this.label8.Text = "-";
            // 
            // MinusLeftLabel
            // 
            this.MinusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusLeftLabel.Location = new System.Drawing.Point(25, 109);
            this.MinusLeftLabel.Name = "MinusLeftLabel";
            this.MinusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusLeftLabel.TabIndex = 7;
            this.MinusLeftLabel.Text = "?";
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(325, 157);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(147, 20);
            this.Product.TabIndex = 4;
            this.Product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(247, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 15;
            this.label10.Text = "=";
            // 
            // TimesRightLabel
            // 
            this.TimesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesRightLabel.Location = new System.Drawing.Point(181, 147);
            this.TimesRightLabel.Name = "TimesRightLabel";
            this.TimesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.TimesRightLabel.TabIndex = 14;
            this.TimesRightLabel.Text = "?";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 13;
            this.label12.Text = "*";
            // 
            // TimesLeftLabel
            // 
            this.TimesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesLeftLabel.Location = new System.Drawing.Point(25, 147);
            this.TimesLeftLabel.Name = "TimesLeftLabel";
            this.TimesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.TimesLeftLabel.TabIndex = 12;
            this.TimesLeftLabel.Text = "?";
            // 
            // Quotient
            // 
            this.Quotient.Location = new System.Drawing.Point(325, 195);
            this.Quotient.Name = "Quotient";
            this.Quotient.Size = new System.Drawing.Size(147, 20);
            this.Quotient.TabIndex = 5;
            this.Quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(247, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 20;
            this.label14.Text = "=";
            // 
            // DevidedRightLabel
            // 
            this.DevidedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevidedRightLabel.Location = new System.Drawing.Point(181, 185);
            this.DevidedRightLabel.Name = "DevidedRightLabel";
            this.DevidedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.DevidedRightLabel.TabIndex = 19;
            this.DevidedRightLabel.Text = "?";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(97, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 50);
            this.label16.TabIndex = 18;
            this.label16.Text = "/";
            // 
            // DevidedLeftLabel
            // 
            this.DevidedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevidedLeftLabel.Location = new System.Drawing.Point(25, 185);
            this.DevidedLeftLabel.Name = "DevidedLeftLabel";
            this.DevidedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.DevidedLeftLabel.TabIndex = 17;
            this.DevidedLeftLabel.Text = "?";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(161, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start the quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Time Left";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quotient);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DevidedRightLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DevidedLeftLabel);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TimesRightLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TimesLeftLabel);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MinusRightLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MinusLeftLabel);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlusLeftLabel);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label PlusLeftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PlusRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Sum;
        private System.Windows.Forms.NumericUpDown Difference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MinusRightLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MinusLeftLabel;
        private System.Windows.Forms.NumericUpDown Product;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TimesRightLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TimesLeftLabel;
        private System.Windows.Forms.NumericUpDown Quotient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label DevidedRightLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label DevidedLeftLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

