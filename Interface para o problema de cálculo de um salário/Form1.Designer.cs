
namespace Interface_para_o_problema_de_cálculo_de_um_salário
{
    partial class frmSalarioMinimo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSalarioMin = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblHorasT = new System.Windows.Forms.Label();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.rbtnMat = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.rbtnCalouro = new System.Windows.Forms.RadioButton();
            this.rbtnVesp = new System.Windows.Forms.RadioButton();
            this.rbtnNot = new System.Windows.Forms.RadioButton();
            this.rbtnVeterano = new System.Windows.Forms.RadioButton();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxTurno.SuspendLayout();
            this.gbxCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioMin
            // 
            this.lblSalarioMin.AutoSize = true;
            this.lblSalarioMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMin.Location = new System.Drawing.Point(12, 12);
            this.lblSalarioMin.Name = "lblSalarioMin";
            this.lblSalarioMin.Size = new System.Drawing.Size(125, 20);
            this.lblSalarioMin.TabIndex = 0;
            this.lblSalarioMin.Text = "Salário Mínimo:";
            this.lblSalarioMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(515, 474);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 30);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblHorasT
            // 
            this.lblHorasT.AutoSize = true;
            this.lblHorasT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasT.Location = new System.Drawing.Point(11, 46);
            this.lblHorasT.Name = "lblHorasT";
            this.lblHorasT.Size = new System.Drawing.Size(157, 20);
            this.lblHorasT.TabIndex = 2;
            this.lblHorasT.Text = "Horas Trabalhadas:";
            // 
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 22;
            this.lbxResumo.Location = new System.Drawing.Point(15, 195);
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxResumo.Size = new System.Drawing.Size(601, 246);
            this.lbxResumo.TabIndex = 3;
            // 
            // rbtnMat
            // 
            this.rbtnMat.AutoSize = true;
            this.rbtnMat.Location = new System.Drawing.Point(19, 47);
            this.rbtnMat.Name = "rbtnMat";
            this.rbtnMat.Size = new System.Drawing.Size(94, 24);
            this.rbtnMat.TabIndex = 4;
            this.rbtnMat.TabStop = true;
            this.rbtnMat.Text = "Matutino";
            this.rbtnMat.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rbtnNot);
            this.gbxTurno.Controls.Add(this.rbtnVesp);
            this.gbxTurno.Controls.Add(this.rbtnMat);
            this.gbxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTurno.Location = new System.Drawing.Point(451, 12);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(165, 177);
            this.gbxTurno.TabIndex = 5;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.rbtnVeterano);
            this.gbxCategoria.Controls.Add(this.rbtnCalouro);
            this.gbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategoria.Location = new System.Drawing.Point(15, 82);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(419, 101);
            this.gbxCategoria.TabIndex = 6;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // rbtnCalouro
            // 
            this.rbtnCalouro.AutoSize = true;
            this.rbtnCalouro.Location = new System.Drawing.Point(6, 45);
            this.rbtnCalouro.Name = "rbtnCalouro";
            this.rbtnCalouro.Size = new System.Drawing.Size(88, 24);
            this.rbtnCalouro.TabIndex = 5;
            this.rbtnCalouro.TabStop = true;
            this.rbtnCalouro.Text = "Calouro";
            this.rbtnCalouro.UseVisualStyleBackColor = true;
            // 
            // rbtnVesp
            // 
            this.rbtnVesp.AutoSize = true;
            this.rbtnVesp.Location = new System.Drawing.Point(19, 88);
            this.rbtnVesp.Name = "rbtnVesp";
            this.rbtnVesp.Size = new System.Drawing.Size(110, 24);
            this.rbtnVesp.TabIndex = 6;
            this.rbtnVesp.TabStop = true;
            this.rbtnVesp.Text = "Vespertino";
            this.rbtnVesp.UseVisualStyleBackColor = true;
            // 
            // rbtnNot
            // 
            this.rbtnNot.AutoSize = true;
            this.rbtnNot.Location = new System.Drawing.Point(19, 134);
            this.rbtnNot.Name = "rbtnNot";
            this.rbtnNot.Size = new System.Drawing.Size(89, 24);
            this.rbtnNot.TabIndex = 7;
            this.rbtnNot.TabStop = true;
            this.rbtnNot.Text = "Noturno";
            this.rbtnNot.UseVisualStyleBackColor = true;
            // 
            // rbtnVeterano
            // 
            this.rbtnVeterano.AutoSize = true;
            this.rbtnVeterano.Location = new System.Drawing.Point(122, 45);
            this.rbtnVeterano.Name = "rbtnVeterano";
            this.rbtnVeterano.Size = new System.Drawing.Size(97, 24);
            this.rbtnVeterano.TabIndex = 6;
            this.rbtnVeterano.TabStop = true;
            this.rbtnVeterano.Text = "Veterano";
            this.rbtnVeterano.UseVisualStyleBackColor = true;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(190, 46);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(244, 22);
            this.txtHorasTrabalhadas.TabIndex = 7;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(190, 12);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(244, 22);
            this.txtSalarioMinimo.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtSalarioMinimo, "Informe o Valor atual do Salário Mínimo");
            // 
            // txtSituacaoEstagiario
            // 
            this.txtSituacaoEstagiario.BackColor = System.Drawing.Color.Yellow;
            this.txtSituacaoEstagiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoEstagiario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtSituacaoEstagiario.Location = new System.Drawing.Point(15, 474);
            this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
            this.txtSituacaoEstagiario.Size = new System.Drawing.Size(494, 30);
            this.txtSituacaoEstagiario.TabIndex = 9;
            this.txtSituacaoEstagiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // frmSalarioMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 518);
            this.Controls.Add(this.txtSituacaoEstagiario);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.lblHorasT);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalarioMin);
            this.Name = "frmSalarioMinimo";
            this.Text = "Cálculo de Salário";
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioMin;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblHorasT;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.RadioButton rbtnMat;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton rbtnNot;
        private System.Windows.Forms.RadioButton rbtnVesp;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton rbtnVeterano;
        private System.Windows.Forms.RadioButton rbtnCalouro;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtSituacaoEstagiario;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

