﻿namespace Exemplo_aula
{
    partial class Form2
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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            listViewClientes = new ListView();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 138);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 11;
            label2.Text = "Entre com e-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 87);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 10;
            label1.Text = "Entre com o nome";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(135, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listViewClientes
            // 
            listViewClientes.Location = new Point(342, 73);
            listViewClientes.Name = "listViewClientes";
            listViewClientes.Size = new Size(357, 264);
            listViewClientes.TabIndex = 12;
            listViewClientes.UseCompatibleStateImageBehavior = false;
            listViewClientes.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 182);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 13;
            label3.Text = "Salario";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 200);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(listViewClientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private ListView listViewClientes;
        private Label label3;
        private TextBox textBox3;
    }
}