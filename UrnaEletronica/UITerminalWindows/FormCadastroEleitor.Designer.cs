﻿namespace UITerminalWindows
{
    partial class FormCadastroEleitor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.checkBoxVotou = new System.Windows.Forms.CheckBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.bindingSourceEleitor = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleitor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(866, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de eleitor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEleitor, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(12, 90);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(360, 27);
            this.textBoxNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Título";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEleitor, "Titulo", true));
            this.textBoxTitulo.Location = new System.Drawing.Point(378, 90);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(360, 27);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // checkBoxVotou
            // 
            this.checkBoxVotou.AutoSize = true;
            this.checkBoxVotou.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceEleitor, "Votou", true));
            this.checkBoxVotou.Location = new System.Drawing.Point(753, 93);
            this.checkBoxVotou.Name = "checkBoxVotou";
            this.checkBoxVotou.Size = new System.Drawing.Size(86, 24);
            this.checkBoxVotou.TabIndex = 3;
            this.checkBoxVotou.Text = "Já votou";
            this.checkBoxVotou.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(660, 409);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(760, 409);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // bindingSourceEleitor
            // 
            this.bindingSourceEleitor.DataSource = typeof(Models.Eleitor);
            // 
            // FormCadastroEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.checkBoxVotou);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroEleitor";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormCadastroEleitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNome;
        private Label label3;
        private TextBox textBoxTitulo;
        private CheckBox checkBoxVotou;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private BindingSource bindingSourceEleitor;
    }
}