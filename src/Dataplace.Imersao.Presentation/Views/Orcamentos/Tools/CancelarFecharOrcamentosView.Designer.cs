namespace Dataplace.Imersao.Presentation.Views.Orcamentos.Tools
{
    partial class CancelarFecharOrcamentosView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarFecharOrcamentosView));
            this.gridOrcamento = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiMarcar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDesmarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAberto = new System.Windows.Forms.CheckBox();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.chkFechado = new System.Windows.Forms.CheckBox();
            this.rangeDate = new dpLibrary05.ucSymGen_ReferenceDtp();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.optReabrir = new System.Windows.Forms.RadioButton();
            this.optFechar = new System.Windows.Forms.RadioButton();
            this.optCancelar = new System.Windows.Forms.RadioButton();
            this.c1SuperTooltip1 = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.c1XLBook1 = new C1.C1Excel.C1XLBook();
            this.dpiVendedor = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiCliente = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiUsuario = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiNumOrcamento = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.lbnTotalizador = new System.Windows.Forms.Label();
            this.rdbNaoValidar = new System.Windows.Forms.RadioButton();
            this.rdbDataOrcamento = new System.Windows.Forms.RadioButton();
            this.rdbDataValidade = new System.Windows.Forms.RadioButton();
            this.rdbDataFechamento = new System.Windows.Forms.RadioButton();
            this.gbOpcoesData = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbAcoes.SuspendLayout();
            this.gbOpcoesData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrcamento
            // 
            this.gridOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOrcamento.GroupByCaption = "Drag a column header here to group by that column";
            this.gridOrcamento.Images.Add(((System.Drawing.Image)(resources.GetObject("gridOrcamento.Images"))));
            this.gridOrcamento.Location = new System.Drawing.Point(3, 165);
            this.gridOrcamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridOrcamento.Name = "gridOrcamento";
            this.gridOrcamento.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.gridOrcamento.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.gridOrcamento.PreviewInfo.ZoomFactor = 75D;
            this.gridOrcamento.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.gridOrcamento.PrintInfo.MeasurementPrinterName = null;
            this.gridOrcamento.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("gridOrcamento.PrintInfo.PageSettings")));
            this.gridOrcamento.Size = new System.Drawing.Size(1341, 445);
            this.gridOrcamento.TabIndex = 3;
            this.gridOrcamento.UseCompatibleTextRendering = false;
            this.gridOrcamento.PropBag = resources.GetString("gridOrcamento.PropBag");
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(1276, 106);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(50, 50);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 683);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(122, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiMarcar,
            this.tsiDesmarca,
            this.tsiExcel});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(109, 24);
            this.toolStripSplitButton1.Text = "Ferramentas";
            // 
            // tsiMarcar
            // 
            this.tsiMarcar.Name = "tsiMarcar";
            this.tsiMarcar.Size = new System.Drawing.Size(220, 26);
            this.tsiMarcar.Text = "Marcar Todos";
            // 
            // tsiDesmarca
            // 
            this.tsiDesmarca.Name = "tsiDesmarca";
            this.tsiDesmarca.Size = new System.Drawing.Size(220, 26);
            this.tsiDesmarca.Text = "Desmarcar Todos";
            // 
            // tsiExcel
            // 
            this.tsiExcel.Name = "tsiExcel";
            this.tsiExcel.Size = new System.Drawing.Size(220, 26);
            this.tsiExcel.Text = "Exportar para excel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAberto);
            this.groupBox1.Controls.Add(this.chkCancelado);
            this.groupBox1.Controls.Add(this.chkFechado);
            this.groupBox1.Location = new System.Drawing.Point(1064, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(203, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação do orçamento";
            // 
            // chkAberto
            // 
            this.chkAberto.AutoSize = true;
            this.chkAberto.Checked = true;
            this.chkAberto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAberto.Location = new System.Drawing.Point(15, 31);
            this.chkAberto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAberto.Name = "chkAberto";
            this.chkAberto.Size = new System.Drawing.Size(69, 20);
            this.chkAberto.TabIndex = 0;
            this.chkAberto.Text = "Aberto";
            this.chkAberto.UseVisualStyleBackColor = true;
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Location = new System.Drawing.Point(15, 107);
            this.chkCancelado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(95, 20);
            this.chkCancelado.TabIndex = 2;
            this.chkCancelado.Text = "Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // chkFechado
            // 
            this.chkFechado.AutoSize = true;
            this.chkFechado.Location = new System.Drawing.Point(15, 67);
            this.chkFechado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFechado.Name = "chkFechado";
            this.chkFechado.Size = new System.Drawing.Size(83, 20);
            this.chkFechado.TabIndex = 1;
            this.chkFechado.Text = "Fechado";
            this.chkFechado.UseVisualStyleBackColor = true;
            // 
            // rangeDate
            // 
            this.rangeDate.Date1CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.Date2CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rangeDate.DotNetContainer = false;
            this.rangeDate.KeyPreview = false;
            this.rangeDate.Label1Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TFrom;
            this.rangeDate.Label2Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TTo;
            this.rangeDate.Location = new System.Drawing.Point(9, 21);
            this.rangeDate.Margin = new System.Windows.Forms.Padding(5);
            this.rangeDate.Name = "rangeDate";
            this.rangeDate.OpenModal = false;
            this.rangeDate.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("rangeDate.Parameters")));
            this.rangeDate.Size = new System.Drawing.Size(464, 27);
            this.rangeDate.TabIndex = 0;
            this.rangeDate.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.rangeDate);
            this.gbData.Location = new System.Drawing.Point(4, 96);
            this.gbData.Margin = new System.Windows.Forms.Padding(4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4);
            this.gbData.Size = new System.Drawing.Size(487, 60);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Período";
            // 
            // gbAcoes
            // 
            this.gbAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAcoes.Controls.Add(this.optReabrir);
            this.gbAcoes.Controls.Add(this.optFechar);
            this.gbAcoes.Controls.Add(this.optCancelar);
            this.gbAcoes.Location = new System.Drawing.Point(4, 616);
            this.gbAcoes.Margin = new System.Windows.Forms.Padding(4);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Padding = new System.Windows.Forms.Padding(4);
            this.gbAcoes.Size = new System.Drawing.Size(1339, 54);
            this.gbAcoes.TabIndex = 4;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "O que deseja fazer?";
            // 
            // optReabrir
            // 
            this.optReabrir.AutoSize = true;
            this.optReabrir.Checked = true;
            this.optReabrir.Location = new System.Drawing.Point(457, 23);
            this.optReabrir.Margin = new System.Windows.Forms.Padding(4);
            this.optReabrir.Name = "optReabrir";
            this.optReabrir.Size = new System.Drawing.Size(140, 20);
            this.optReabrir.TabIndex = 7;
            this.optReabrir.TabStop = true;
            this.optReabrir.Text = "Reabrir orçamento";
            this.optReabrir.UseVisualStyleBackColor = true;
            // 
            // optFechar
            // 
            this.optFechar.AutoSize = true;
            this.optFechar.Checked = true;
            this.optFechar.Location = new System.Drawing.Point(234, 23);
            this.optFechar.Margin = new System.Windows.Forms.Padding(4);
            this.optFechar.Name = "optFechar";
            this.optFechar.Size = new System.Drawing.Size(137, 20);
            this.optFechar.TabIndex = 0;
            this.optFechar.TabStop = true;
            this.optFechar.Text = "Fechar orçamento";
            this.optFechar.UseVisualStyleBackColor = true;
            // 
            // optCancelar
            // 
            this.optCancelar.AutoSize = true;
            this.optCancelar.Location = new System.Drawing.Point(32, 23);
            this.optCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.optCancelar.Name = "optCancelar";
            this.optCancelar.Size = new System.Drawing.Size(149, 20);
            this.optCancelar.TabIndex = 6;
            this.optCancelar.Text = "Cancelar orçamento";
            this.optCancelar.UseVisualStyleBackColor = true;
            // 
            // c1SuperTooltip1
            // 
            this.c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1SuperTooltip1.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            // 
            // dpiVendedor
            // 
            this.dpiVendedor.Active = false;
            this.dpiVendedor.DataSource = null;
            this.dpiVendedor.DP_Caption = "2799";
            this.dpiVendedor.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiVendedor.DP_DataField = null;
            this.dpiVendedor.DP_FilterMemo = false;
            this.dpiVendedor.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.SearchValueInput;
            this.dpiVendedor.DP_Length = 0;
            this.dpiVendedor.DP_Maximum = null;
            this.dpiVendedor.DP_Minimum = null;
            this.dpiVendedor.DP_NumericPrecision = 0;
            this.dpiVendedor.EditMask = null;
            this.dpiVendedor.EditMaskUpdate = false;
            this.dpiVendedor.FindMode = false;
            this.dpiVendedor.InterfaceField = null;
            this.dpiVendedor.IsReadonly = false;
            this.dpiVendedor.Location = new System.Drawing.Point(521, 65);
            this.dpiVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.dpiVendedor.Multiline = false;
            this.dpiVendedor.Name = "dpiVendedor";
            this.dpiVendedor.SearchObject = null;
            this.dpiVendedor.SettingValue = false;
            this.dpiVendedor.Size = new System.Drawing.Size(533, 45);
            this.dpiVendedor.TabIndex = 503;
            // 
            // dpiCliente
            // 
            this.dpiCliente.Active = false;
            this.dpiCliente.DataSource = null;
            this.dpiCliente.DP_Caption = "2791";
            this.dpiCliente.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiCliente.DP_DataField = null;
            this.dpiCliente.DP_FilterMemo = false;
            this.dpiCliente.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.SearchValueInput;
            this.dpiCliente.DP_Length = 0;
            this.dpiCliente.DP_Maximum = null;
            this.dpiCliente.DP_Minimum = null;
            this.dpiCliente.DP_NumericPrecision = 0;
            this.dpiCliente.EditMask = null;
            this.dpiCliente.EditMaskUpdate = false;
            this.dpiCliente.FindMode = false;
            this.dpiCliente.InterfaceField = null;
            this.dpiCliente.IsReadonly = false;
            this.dpiCliente.Location = new System.Drawing.Point(521, 15);
            this.dpiCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dpiCliente.Multiline = false;
            this.dpiCliente.Name = "dpiCliente";
            this.dpiCliente.SearchObject = null;
            this.dpiCliente.SettingValue = false;
            this.dpiCliente.Size = new System.Drawing.Size(533, 45);
            this.dpiCliente.TabIndex = 504;
            // 
            // dpiUsuario
            // 
            this.dpiUsuario.Active = false;
            this.dpiUsuario.DataSource = null;
            this.dpiUsuario.DP_Caption = "3879";
            this.dpiUsuario.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiUsuario.DP_DataField = null;
            this.dpiUsuario.DP_FilterMemo = false;
            this.dpiUsuario.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.SearchValueInput;
            this.dpiUsuario.DP_Length = 0;
            this.dpiUsuario.DP_Maximum = null;
            this.dpiUsuario.DP_Minimum = null;
            this.dpiUsuario.DP_NumericPrecision = 0;
            this.dpiUsuario.EditMask = null;
            this.dpiUsuario.EditMaskUpdate = false;
            this.dpiUsuario.FindMode = false;
            this.dpiUsuario.InterfaceField = null;
            this.dpiUsuario.IsReadonly = false;
            this.dpiUsuario.Location = new System.Drawing.Point(521, 114);
            this.dpiUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.dpiUsuario.Multiline = false;
            this.dpiUsuario.Name = "dpiUsuario";
            this.dpiUsuario.SearchObject = null;
            this.dpiUsuario.SettingValue = false;
            this.dpiUsuario.Size = new System.Drawing.Size(533, 45);
            this.dpiUsuario.TabIndex = 505;
            // 
            // dpiNumOrcamento
            // 
            this.dpiNumOrcamento.Active = false;
            this.dpiNumOrcamento.DataSource = null;
            this.dpiNumOrcamento.DP_Caption = "3182";
            this.dpiNumOrcamento.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiNumOrcamento.DP_DataField = null;
            this.dpiNumOrcamento.DP_FilterMemo = false;
            this.dpiNumOrcamento.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.StringInput;
            this.dpiNumOrcamento.DP_Length = 0;
            this.dpiNumOrcamento.DP_Maximum = null;
            this.dpiNumOrcamento.DP_Minimum = null;
            this.dpiNumOrcamento.DP_NumericPrecision = 0;
            this.dpiNumOrcamento.EditMask = null;
            this.dpiNumOrcamento.EditMaskUpdate = false;
            this.dpiNumOrcamento.FindMode = false;
            this.dpiNumOrcamento.InterfaceField = null;
            this.dpiNumOrcamento.IsReadonly = false;
            this.dpiNumOrcamento.Location = new System.Drawing.Point(8, 22);
            this.dpiNumOrcamento.Margin = new System.Windows.Forms.Padding(4);
            this.dpiNumOrcamento.Multiline = false;
            this.dpiNumOrcamento.Name = "dpiNumOrcamento";
            this.dpiNumOrcamento.SearchObject = null;
            this.dpiNumOrcamento.SettingValue = false;
            this.dpiNumOrcamento.Size = new System.Drawing.Size(92, 44);
            this.dpiNumOrcamento.TabIndex = 506;
            // 
            // lbnTotalizador
            // 
            this.lbnTotalizador.AutoSize = true;
            this.lbnTotalizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTotalizador.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbnTotalizador.Location = new System.Drawing.Point(138, 688);
            this.lbnTotalizador.Name = "lbnTotalizador";
            this.lbnTotalizador.Size = new System.Drawing.Size(50, 16);
            this.lbnTotalizador.TabIndex = 507;
            this.lbnTotalizador.Text = "label1";
            // 
            // rdbNaoValidar
            // 
            this.rdbNaoValidar.AutoSize = true;
            this.rdbNaoValidar.Location = new System.Drawing.Point(6, 20);
            this.rdbNaoValidar.Name = "rdbNaoValidar";
            this.rdbNaoValidar.Size = new System.Drawing.Size(151, 20);
            this.rdbNaoValidar.TabIndex = 508;
            this.rdbNaoValidar.TabStop = true;
            this.rdbNaoValidar.Text = "Não Validar Período";
            this.rdbNaoValidar.UseVisualStyleBackColor = true;
            // 
            // rdbDataOrcamento
            // 
            this.rdbDataOrcamento.AutoSize = true;
            this.rdbDataOrcamento.Location = new System.Drawing.Point(6, 46);
            this.rdbDataOrcamento.Name = "rdbDataOrcamento";
            this.rdbDataOrcamento.Size = new System.Drawing.Size(126, 20);
            this.rdbDataOrcamento.TabIndex = 509;
            this.rdbDataOrcamento.TabStop = true;
            this.rdbDataOrcamento.Text = "Data Orçamento";
            this.rdbDataOrcamento.UseVisualStyleBackColor = true;
            // 
            // rdbDataValidade
            // 
            this.rdbDataValidade.AutoSize = true;
            this.rdbDataValidade.Location = new System.Drawing.Point(174, 46);
            this.rdbDataValidade.Name = "rdbDataValidade";
            this.rdbDataValidade.Size = new System.Drawing.Size(115, 20);
            this.rdbDataValidade.TabIndex = 511;
            this.rdbDataValidade.TabStop = true;
            this.rdbDataValidade.Text = "Data Validade";
            this.rdbDataValidade.UseVisualStyleBackColor = true;
            // 
            // rdbDataFechamento
            // 
            this.rdbDataFechamento.AutoSize = true;
            this.rdbDataFechamento.Location = new System.Drawing.Point(174, 20);
            this.rdbDataFechamento.Name = "rdbDataFechamento";
            this.rdbDataFechamento.Size = new System.Drawing.Size(135, 20);
            this.rdbDataFechamento.TabIndex = 510;
            this.rdbDataFechamento.TabStop = true;
            this.rdbDataFechamento.Text = "Data Fechamento";
            this.rdbDataFechamento.UseVisualStyleBackColor = true;
            // 
            // gbOpcoesData
            // 
            this.gbOpcoesData.Controls.Add(this.rdbDataValidade);
            this.gbOpcoesData.Controls.Add(this.rdbDataFechamento);
            this.gbOpcoesData.Controls.Add(this.rdbDataOrcamento);
            this.gbOpcoesData.Controls.Add(this.rdbNaoValidar);
            this.gbOpcoesData.Location = new System.Drawing.Point(141, 15);
            this.gbOpcoesData.Name = "gbOpcoesData";
            this.gbOpcoesData.Size = new System.Drawing.Size(350, 74);
            this.gbOpcoesData.TabIndex = 512;
            this.gbOpcoesData.TabStop = false;
            this.gbOpcoesData.Text = "Opções";
            // 
            // CancelarFehacrOrcamentosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOpcoesData);
            this.Controls.Add(this.lbnTotalizador);
            this.Controls.Add(this.dpiNumOrcamento);
            this.Controls.Add(this.dpiUsuario);
            this.Controls.Add(this.dpiCliente);
            this.Controls.Add(this.dpiVendedor);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.gridOrcamento);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CancelarFehacrOrcamentosView";
            this.Size = new System.Drawing.Size(1347, 750);
            this.Controls.SetChildIndex(this.gridOrcamento, 0);
            this.Controls.SetChildIndex(this.btnCarregar, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.gbAcoes, 0);
            this.Controls.SetChildIndex(this.dpiVendedor, 0);
            this.Controls.SetChildIndex(this.dpiCliente, 0);
            this.Controls.SetChildIndex(this.dpiUsuario, 0);
            this.Controls.SetChildIndex(this.dpiNumOrcamento, 0);
            this.Controls.SetChildIndex(this.lbnTotalizador, 0);
            this.Controls.SetChildIndex(this.gbOpcoesData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbAcoes.ResumeLayout(false);
            this.gbAcoes.PerformLayout();
            this.gbOpcoesData.ResumeLayout(false);
            this.gbOpcoesData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid gridOrcamento;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsiMarcar;
        private System.Windows.Forms.ToolStripMenuItem tsiDesmarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAberto;
        private System.Windows.Forms.CheckBox chkCancelado;
        private System.Windows.Forms.CheckBox chkFechado;
        private System.Windows.Forms.ToolStripMenuItem tsiExcel;
        internal dpLibrary05.ucSymGen_ReferenceDtp rangeDate;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.RadioButton optFechar;
        private System.Windows.Forms.RadioButton optCancelar;
        private System.Windows.Forms.RadioButton optReabrir;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1SuperTooltip1;
        private C1.C1Excel.C1XLBook c1XLBook1;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiVendedor;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiCliente;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiUsuario;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiNumOrcamento;
        private System.Windows.Forms.Label lbnTotalizador;
        private System.Windows.Forms.RadioButton rdbNaoValidar;
        private System.Windows.Forms.RadioButton rdbDataOrcamento;
        private System.Windows.Forms.RadioButton rdbDataValidade;
        private System.Windows.Forms.RadioButton rdbDataFechamento;
        private System.Windows.Forms.GroupBox gbOpcoesData;
    }
}
