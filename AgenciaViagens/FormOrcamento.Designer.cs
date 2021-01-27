namespace AgenciaViagens
{
    partial class FormOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrcamento));
            this.label1_Nome = new System.Windows.Forms.Label();
            this.textBox1_Nome = new System.Windows.Forms.TextBox();
            this.label1_Destino = new System.Windows.Forms.Label();
            this.label1_Valor = new System.Windows.Forms.Label();
            this.button1_Calculadora = new System.Windows.Forms.Button();
            this.label1_Vlr = new System.Windows.Forms.Label();
            this.groupBoxFormaPag = new System.Windows.Forms.GroupBox();
            this.radioButton1Parcelado = new System.Windows.Forms.RadioButton();
            this.radioButton1Vista = new System.Windows.Forms.RadioButton();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxFormaPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_Nome
            // 
            this.label1_Nome.AutoSize = true;
            this.label1_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Nome.Location = new System.Drawing.Point(18, 42);
            this.label1_Nome.Name = "label1_Nome";
            this.label1_Nome.Size = new System.Drawing.Size(45, 16);
            this.label1_Nome.TabIndex = 7;
            this.label1_Nome.Text = "Nome";
            this.label1_Nome.Click += new System.EventHandler(this.label1_Nome_Click);
            // 
            // textBox1_Nome
            // 
            this.textBox1_Nome.Location = new System.Drawing.Point(87, 41);
            this.textBox1_Nome.Name = "textBox1_Nome";
            this.textBox1_Nome.Size = new System.Drawing.Size(317, 20);
            this.textBox1_Nome.TabIndex = 1;
            this.textBox1_Nome.Leave += new System.EventHandler(this.TextBox1_Nome_Leave);
            // 
            // label1_Destino
            // 
            this.label1_Destino.AutoSize = true;
            this.label1_Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Destino.Location = new System.Drawing.Point(18, 88);
            this.label1_Destino.Name = "label1_Destino";
            this.label1_Destino.Size = new System.Drawing.Size(54, 16);
            this.label1_Destino.TabIndex = 7;
            this.label1_Destino.Text = "Destino";
            // 
            // label1_Valor
            // 
            this.label1_Valor.AutoSize = true;
            this.label1_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Valor.Location = new System.Drawing.Point(24, 259);
            this.label1_Valor.Name = "label1_Valor";
            this.label1_Valor.Size = new System.Drawing.Size(40, 16);
            this.label1_Valor.TabIndex = 7;
            this.label1_Valor.Text = "Valor";
            // 
            // button1_Calculadora
            // 
            this.button1_Calculadora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1_Calculadora.BackgroundImage")));
            this.button1_Calculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1_Calculadora.Location = new System.Drawing.Point(469, 142);
            this.button1_Calculadora.Name = "button1_Calculadora";
            this.button1_Calculadora.Size = new System.Drawing.Size(192, 133);
            this.button1_Calculadora.TabIndex = 5;
            this.button1_Calculadora.UseVisualStyleBackColor = true;
            this.button1_Calculadora.Click += new System.EventHandler(this.button1_Orçamento);
            // 
            // label1_Vlr
            // 
            this.label1_Vlr.AutoSize = true;
            this.label1_Vlr.Location = new System.Drawing.Point(84, 261);
            this.label1_Vlr.Name = "label1_Vlr";
            this.label1_Vlr.Size = new System.Drawing.Size(73, 13);
            this.label1_Vlr.TabIndex = 4;
            this.label1_Vlr.Text = "___________";
            this.label1_Vlr.Click += new System.EventHandler(this.Label1_Vlr_Click);
            // 
            // groupBoxFormaPag
            // 
            this.groupBoxFormaPag.Controls.Add(this.radioButton1Parcelado);
            this.groupBoxFormaPag.Controls.Add(this.radioButton1Vista);
            this.groupBoxFormaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFormaPag.Location = new System.Drawing.Point(21, 131);
            this.groupBoxFormaPag.Name = "groupBoxFormaPag";
            this.groupBoxFormaPag.Size = new System.Drawing.Size(187, 90);
            this.groupBoxFormaPag.TabIndex = 3;
            this.groupBoxFormaPag.TabStop = false;
            this.groupBoxFormaPag.Text = "Forma de Pagamento";
            // 
            // radioButton1Parcelado
            // 
            this.radioButton1Parcelado.AutoSize = true;
            this.radioButton1Parcelado.Location = new System.Drawing.Point(81, 40);
            this.radioButton1Parcelado.Name = "radioButton1Parcelado";
            this.radioButton1Parcelado.Size = new System.Drawing.Size(89, 20);
            this.radioButton1Parcelado.TabIndex = 1;
            this.radioButton1Parcelado.TabStop = true;
            this.radioButton1Parcelado.Text = "Parcelado";
            this.radioButton1Parcelado.UseVisualStyleBackColor = true;
            // 
            // radioButton1Vista
            // 
            this.radioButton1Vista.AutoSize = true;
            this.radioButton1Vista.Location = new System.Drawing.Point(6, 40);
            this.radioButton1Vista.Name = "radioButton1Vista";
            this.radioButton1Vista.Size = new System.Drawing.Size(56, 20);
            this.radioButton1Vista.TabIndex = 0;
            this.radioButton1Vista.TabStop = true;
            this.radioButton1Vista.Text = "Vista";
            this.radioButton1Vista.UseVisualStyleBackColor = true;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "Natal"});
            this.comboBoxDestino.Location = new System.Drawing.Point(87, 82);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestino.TabIndex = 2;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // FormOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 307);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.groupBoxFormaPag);
            this.Controls.Add(this.label1_Vlr);
            this.Controls.Add(this.button1_Calculadora);
            this.Controls.Add(this.label1_Valor);
            this.Controls.Add(this.label1_Destino);
            this.Controls.Add(this.textBox1_Nome);
            this.Controls.Add(this.label1_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrcamento";
            this.Text = "Orçamento";
            this.groupBoxFormaPag.ResumeLayout(false);
            this.groupBoxFormaPag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Nome;
        private System.Windows.Forms.TextBox textBox1_Nome;
        private System.Windows.Forms.Label label1_Destino;
        private System.Windows.Forms.Label label1_Valor;
        private System.Windows.Forms.Button button1_Calculadora;
        private System.Windows.Forms.Label label1_Vlr;
        private System.Windows.Forms.GroupBox groupBoxFormaPag;
        private System.Windows.Forms.RadioButton radioButton1Parcelado;
        private System.Windows.Forms.RadioButton radioButton1Vista;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}