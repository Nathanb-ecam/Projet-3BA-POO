namespace WindowsFormsApp2
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
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape5 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape6 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape7 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector2 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector3 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector4 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector5 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector6 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector7 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramShape8 = new DevExpress.XtraDiagram.DiagramShape();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramShape3,
            this.diagramShape4,
            this.diagramShape5,
            this.diagramShape6,
            this.diagramShape7,
            this.diagramConnector1,
            this.diagramConnector2,
            this.diagramConnector3,
            this.diagramConnector4,
            this.diagramConnector5,
            this.diagramConnector6,
            this.diagramConnector7,
            this.diagramShape8});
            this.diagramControl1.Location = new System.Drawing.Point(0, 0);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.Size = new System.Drawing.Size(800, 450);
            this.diagramControl1.TabIndex = 0;
            this.diagramControl1.Text = "diagramControl1";
            // 
            // diagramShape1
            // 
            this.diagramShape1.Content = "Entreprise";
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(140F, 330F);
            this.diagramShape1.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape1.Size = new System.Drawing.SizeF(100F, 75F);
            // 
            // diagramShape2
            // 
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(240F, 360F);
            this.diagramShape2.Shape = DevExpress.Diagram.Core.BasicShapes.Decagon;
            this.diagramShape2.Size = new System.Drawing.SizeF(15F, 15F);
            // 
            // diagramShape3
            // 
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(650F, 360F);
            this.diagramShape3.Shape = DevExpress.Diagram.Core.BasicShapes.Decagon;
            this.diagramShape3.Size = new System.Drawing.SizeF(15F, 15F);
            // 
            // diagramShape4
            // 
            this.diagramShape4.Content = "nucléaire";
            this.diagramShape4.Position = new DevExpress.Utils.PointFloat(750F, 120F);
            this.diagramShape4.Size = new System.Drawing.SizeF(100F, 75F);
            // 
            // diagramShape5
            // 
            this.diagramShape5.Content = "GAZ";
            this.diagramShape5.Position = new DevExpress.Utils.PointFloat(750F, 220F);
            this.diagramShape5.Shape = DevExpress.Diagram.Core.BasicShapes.Triangle;
            this.diagramShape5.Size = new System.Drawing.SizeF(100F, 90F);
            // 
            // diagramShape6
            // 
            this.diagramShape6.Content = "parc éolien";
            this.diagramShape6.Position = new DevExpress.Utils.PointFloat(750F, 330F);
            this.diagramShape6.Shape = DevExpress.Diagram.Core.BasicShapes.Pentagon;
            this.diagramShape6.Size = new System.Drawing.SizeF(100F, 100F);
            // 
            // diagramShape7
            // 
            this.diagramShape7.Content = "solaire";
            this.diagramShape7.Position = new DevExpress.Utils.PointFloat(750F, 460F);
            this.diagramShape7.Shape = DevExpress.Diagram.Core.BasicShapes.Hexagon;
            this.diagramShape7.Size = new System.Drawing.SizeF(100F, 100F);
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginItem = this.diagramShape4;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(750F, 157.5F);
            this.diagramConnector1.EndItem = this.diagramShape3;
            this.diagramConnector1.EndItemPointIndex = 8;
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(659.8176F, 360.3671F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(800F, 210F),
            new DevExpress.Utils.PointFloat(659.8176F, 210F)});
            // 
            // diagramConnector2
            // 
            this.diagramConnector2.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector2.BeginItem = this.diagramShape5;
            this.diagramConnector2.BeginPoint = new DevExpress.Utils.PointFloat(750F, 310F);
            this.diagramConnector2.EndItem = this.diagramShape3;
            this.diagramConnector2.EndItemPointIndex = 0;
            this.diagramConnector2.EndPoint = new DevExpress.Utils.PointFloat(665F, 367.5F);
            this.diagramConnector2.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(682F, 310F),
            new DevExpress.Utils.PointFloat(682F, 367.5F)});
            // 
            // diagramConnector3
            // 
            this.diagramConnector3.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector3.BeginItem = this.diagramShape6;
            this.diagramConnector3.BeginPoint = new DevExpress.Utils.PointFloat(752.4472F, 364.5492F);
            this.diagramConnector3.EndItem = this.diagramShape6;
            this.diagramConnector3.EndPoint = new DevExpress.Utils.PointFloat(752.4472F, 364.5492F);
            this.diagramConnector3.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            // 
            // diagramConnector4
            // 
            this.diagramConnector4.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector4.BeginItem = this.diagramShape6;
            this.diagramConnector4.BeginPoint = new DevExpress.Utils.PointFloat(770.6107F, 420.4508F);
            this.diagramConnector4.EndItem = this.diagramShape6;
            this.diagramConnector4.EndPoint = new DevExpress.Utils.PointFloat(752.4472F, 364.5492F);
            this.diagramConnector4.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            // 
            // diagramConnector5
            // 
            this.diagramConnector5.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector5.BeginItem = this.diagramShape6;
            this.diagramConnector5.BeginItemPointIndex = 3;
            this.diagramConnector5.BeginPoint = new DevExpress.Utils.PointFloat(770.6107F, 420.4508F);
            this.diagramConnector5.EndItem = this.diagramShape3;
            this.diagramConnector5.EndItemPointIndex = 1;
            this.diagramConnector5.EndPoint = new DevExpress.Utils.PointFloat(663.5676F, 371.9084F);
            this.diagramConnector5.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(682F, 420.4508F),
            new DevExpress.Utils.PointFloat(682F, 371.9084F)});
            // 
            // diagramConnector6
            // 
            this.diagramConnector6.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector6.BeginItem = this.diagramShape7;
            this.diagramConnector6.BeginItemPointIndex = 3;
            this.diagramConnector6.BeginPoint = new DevExpress.Utils.PointFloat(750F, 510F);
            this.diagramConnector6.EndItem = this.diagramShape3;
            this.diagramConnector6.EndItemPointIndex = 2;
            this.diagramConnector6.EndPoint = new DevExpress.Utils.PointFloat(659.8176F, 374.6329F);
            this.diagramConnector6.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(659.8176F, 510F)});
            // 
            // diagramConnector7
            // 
            this.diagramConnector7.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector7.BeginItem = this.diagramShape3;
            this.diagramConnector7.BeginItemPointIndex = 5;
            this.diagramConnector7.BeginPoint = new DevExpress.Utils.PointFloat(650F, 367.5F);
            this.diagramConnector7.EndItem = this.diagramShape2;
            this.diagramConnector7.EndItemPointIndex = 0;
            this.diagramConnector7.EndPoint = new DevExpress.Utils.PointFloat(255F, 367.5F);
            this.diagramConnector7.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            // 
            // diagramShape8
            // 
            this.diagramShape8.Position = new DevExpress.Utils.PointFloat(240F, 340F);
            this.diagramShape8.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape8.Size = new System.Drawing.SizeF(20F, 15F);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diagramControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraDiagram.DiagramShape diagramShape3;
        private DevExpress.XtraDiagram.DiagramShape diagramShape4;
        private DevExpress.XtraDiagram.DiagramShape diagramShape5;
        private DevExpress.XtraDiagram.DiagramShape diagramShape6;
        private DevExpress.XtraDiagram.DiagramShape diagramShape7;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector1;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector2;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector3;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector4;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector5;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector6;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector7;
        private DevExpress.XtraDiagram.DiagramShape diagramShape8;
    }
}

