namespace AgenciaViagens
{
    partial class FormFuncionarios
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
            this.components = new System.ComponentModel.Container();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.groupBoxRegimeT = new System.Windows.Forms.GroupBox();
            this.radioButtonMensal = new System.Windows.Forms.RadioButton();
            this.radioButtonHor = new System.Windows.Forms.RadioButton();
            this.buttonFicha = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxRegimeT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(143, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(316, 24);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "CADASTRO DE FUNCIONÁRIOS";
            this.labelTitulo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(36, 66);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 16);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(98, 63);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(177, 20);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.Leave += new System.EventHandler(this.TextBoxNome_Leave);
            // 
            // groupBoxRegimeT
            // 
            this.groupBoxRegimeT.Controls.Add(this.radioButtonMensal);
            this.groupBoxRegimeT.Controls.Add(this.radioButtonHor);
            this.groupBoxRegimeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegimeT.Location = new System.Drawing.Point(55, 133);
            this.groupBoxRegimeT.Name = "groupBoxRegimeT";
            this.groupBoxRegimeT.Size = new System.Drawing.Size(220, 83);
            this.groupBoxRegimeT.TabIndex = 2;
            this.groupBoxRegimeT.TabStop = false;
            this.groupBoxRegimeT.Text = "Regime de Trabalho";
            // 
            // radioButtonMensal
            // 
            this.radioButtonMensal.AutoSize = true;
            this.radioButtonMensal.Location = new System.Drawing.Point(116, 39);
            this.radioButtonMensal.Name = "radioButtonMensal";
            this.radioButtonMensal.Size = new System.Drawing.Size(91, 20);
            this.radioButtonMensal.TabIndex = 1;
            this.radioButtonMensal.TabStop = true;
            this.radioButtonMensal.Text = "Mensalista";
            this.radioButtonMensal.UseVisualStyleBackColor = true;
            this.radioButtonMensal.CheckedChanged += new System.EventHandler(this.RadioButtonMensal_CheckedChanged);
            // 
            // radioButtonHor
            // 
            this.radioButtonHor.AutoSize = true;
            this.radioButtonHor.Location = new System.Drawing.Point(18, 39);
            this.radioButtonHor.Name = "radioButtonHor";
            this.radioButtonHor.Size = new System.Drawing.Size(69, 20);
            this.radioButtonHor.TabIndex = 0;
            this.radioButtonHor.TabStop = true;
            this.radioButtonHor.Text = "Horista";
            this.radioButtonHor.UseVisualStyleBackColor = true;
            this.radioButtonHor.CheckedChanged += new System.EventHandler(this.RadioButtonHor_CheckedChanged);
            // 
            // buttonFicha
            // 
            this.buttonFicha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFicha.Location = new System.Drawing.Point(98, 279);
            this.buttonFicha.Name = "buttonFicha";
            this.buttonFicha.Size = new System.Drawing.Size(106, 75);
            this.buttonFicha.TabIndex = 3;
            this.buttonFicha.Text = "GERAR FICHA";
            this.buttonFicha.UseVisualStyleBackColor = false;
            this.buttonFicha.Click += new System.EventHandler(this.ButtonFicha_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 375);
            this.Controls.Add(this.buttonFicha);
            this.Controls.Add(this.groupBoxRegimeT);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormFuncionarios";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.groupBoxRegimeT.ResumeLayout(false);
            this.groupBoxRegimeT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.GroupBox groupBoxRegimeT;
        private System.Windows.Forms.RadioButton radioButtonMensal;
        private System.Windows.Forms.RadioButton radioButtonHor;
        private System.Windows.Forms.Button buttonFicha;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}