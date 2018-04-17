// ********************************************************************************************************
// Product Name: DotSpatial.Symbology.Forms.dll
// Description:  The Windows Forms user interface layer for the DotSpatial.Symbology library.
// ********************************************************************************************************
// The contents of this file are subject to the MIT License (MIT)
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
// http://dotspatial.codeplex.com/license
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF
// ANY KIND, either expressed or implied. See the License for the specific language governing rights and
// limitations under the License.
//
// The Original Code is from MapWindow.dll version 6.0
//
// The Initial Developer of this Original Code is Ted Dunsford. Created 5/21/2009 10:46:15 AM
//
// Contributor(s): (Open source contributors should list themselves and their modifications here).
//
// ********************************************************************************************************

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DotSpatial.Symbology.Forms
{
    /// <summary>
    /// A collection of controls that are specifically designed to work with the outline on a polygon.
    /// </summary>
    [DefaultEvent("OutlineChanged")]
    public class OutlineControl : UserControl
    {
        #region Events

        /// <summary>
        /// Occurs when any of the symbolic aspects of this control are changed.
        /// </summary>
        public event EventHandler OutlineChanged;

        /// <summary>
        /// Occurs specifically when changes are applied from the line symbolizer editor
        /// </summary>
        public event EventHandler ChangesApplied;

        #endregion

        #region Private Variables

        private readonly IPattern _original;
        private bool _ignoreChanges;
        private IPattern _pattern;
        private Button btnEditOutline;
        private ColorButton cbOutlineColor;
        private CheckBox chkUseOutline;
        private DoubleBox dbxOutlineWidth;
        private GroupBox grpOutline;
        private Label label2;
        private RampSlider sldOutlineOpacity;

        #endregion

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutlineControl));
            this.grpOutline = new System.Windows.Forms.GroupBox();
            this.btnEditOutline = new System.Windows.Forms.Button();
            this.cbOutlineColor = new DotSpatial.Symbology.Forms.ColorButton();
            this.sldOutlineOpacity = new DotSpatial.Symbology.Forms.RampSlider();
            this.label2 = new System.Windows.Forms.Label();
            this.dbxOutlineWidth = new DotSpatial.Symbology.Forms.DoubleBox();
            this.chkUseOutline = new System.Windows.Forms.CheckBox();
            this.grpOutline.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOutline
            // 
            resources.ApplyResources(this.grpOutline, "grpOutline");
            this.grpOutline.Controls.Add(this.btnEditOutline);
            this.grpOutline.Controls.Add(this.cbOutlineColor);
            this.grpOutline.Controls.Add(this.sldOutlineOpacity);
            this.grpOutline.Controls.Add(this.label2);
            this.grpOutline.Controls.Add(this.dbxOutlineWidth);
            this.grpOutline.Controls.Add(this.chkUseOutline);
            this.grpOutline.Name = "grpOutline";
            this.grpOutline.TabStop = false;
            // 
            // btnEditOutline
            // 
            resources.ApplyResources(this.btnEditOutline, "btnEditOutline");
            this.btnEditOutline.Name = "btnEditOutline";
            this.btnEditOutline.UseVisualStyleBackColor = true;
            this.btnEditOutline.Click += new System.EventHandler(this.btnEditOutline_Click);
            // 
            // cbOutlineColor
            // 
            resources.ApplyResources(this.cbOutlineColor, "cbOutlineColor");
            this.cbOutlineColor.BevelRadius = 4;
            this.cbOutlineColor.Color = System.Drawing.Color.Blue;
            this.cbOutlineColor.LaunchDialogOnClick = true;
            this.cbOutlineColor.Name = "cbOutlineColor";
            this.cbOutlineColor.RoundingRadius = 10;
            this.cbOutlineColor.ColorChanged += new System.EventHandler(this.cbOutlineColor_ColorChanged);
            // 
            // sldOutlineOpacity
            // 
            resources.ApplyResources(this.sldOutlineOpacity, "sldOutlineOpacity");
            this.sldOutlineOpacity.ColorButton = null;
            this.sldOutlineOpacity.FlipRamp = false;
            this.sldOutlineOpacity.FlipText = false;
            this.sldOutlineOpacity.InvertRamp = false;
            this.sldOutlineOpacity.Maximum = 1D;
            this.sldOutlineOpacity.MaximumColor = System.Drawing.Color.CornflowerBlue;
            this.sldOutlineOpacity.Minimum = 0D;
            this.sldOutlineOpacity.MinimumColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sldOutlineOpacity.Name = "sldOutlineOpacity";
            this.sldOutlineOpacity.NumberFormat = null;
            this.sldOutlineOpacity.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sldOutlineOpacity.RampRadius = 8F;
            this.sldOutlineOpacity.RampText = "Opacity";
            this.sldOutlineOpacity.RampTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.sldOutlineOpacity.RampTextBehindRamp = true;
            this.sldOutlineOpacity.RampTextColor = System.Drawing.Color.Black;
            this.sldOutlineOpacity.RampTextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sldOutlineOpacity.ShowMaximum = true;
            this.sldOutlineOpacity.ShowMinimum = true;
            this.sldOutlineOpacity.ShowTicks = true;
            this.sldOutlineOpacity.ShowValue = false;
            this.sldOutlineOpacity.SliderColor = System.Drawing.Color.SteelBlue;
            this.sldOutlineOpacity.SliderRadius = 4F;
            this.sldOutlineOpacity.TickColor = System.Drawing.Color.DarkGray;
            this.sldOutlineOpacity.TickSpacing = 5F;
            this.sldOutlineOpacity.Value = 0D;
            this.sldOutlineOpacity.ValueChanged += new System.EventHandler(this.sldOutlineOpacity_ValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dbxOutlineWidth
            // 
            resources.ApplyResources(this.dbxOutlineWidth, "dbxOutlineWidth");
            this.dbxOutlineWidth.BackColorInvalid = System.Drawing.Color.Salmon;
            this.dbxOutlineWidth.BackColorRegular = System.Drawing.Color.Empty;
            this.dbxOutlineWidth.InvalidHelp = "The value entered could not be correctly parsed into a valid double precision flo" +
    "ating point value.";
            this.dbxOutlineWidth.IsValid = true;
            this.dbxOutlineWidth.Name = "dbxOutlineWidth";
            this.dbxOutlineWidth.NumberFormat = null;
            this.dbxOutlineWidth.RegularHelp = "Enter a double precision floating point value.";
            this.dbxOutlineWidth.Value = 0D;
            this.dbxOutlineWidth.TextChanged += new System.EventHandler(this.dbxOutlineWidth_TextChanged);
            // 
            // chkUseOutline
            // 
            resources.ApplyResources(this.chkUseOutline, "chkUseOutline");
            this.chkUseOutline.Name = "chkUseOutline";
            this.chkUseOutline.UseVisualStyleBackColor = true;
            this.chkUseOutline.CheckedChanged += new System.EventHandler(this.chkUseOutline_CheckedChanged);
            // 
            // OutlineControl
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.grpOutline);
            this.Name = "OutlineControl";
            this.grpOutline.ResumeLayout(false);
            this.grpOutline.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new, blank instanceo of the outline control
        /// </summary>
        public OutlineControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an outline control that uses the specified pattern to define its configuration.
        /// </summary>
        /// <param name="pattern">The pattern that will be modified during changes.</param>
        public OutlineControl(IPattern pattern)
        {
            _pattern = pattern;
        }

        /// <summary>
        /// Creates an outline control that uses the specified pattern to define its configuration.
        /// </summary>
        /// <param name="original">When apply changes are clicked, the map will be updated when these changes are copied over.</param>
        /// <param name="display">The pattern that will be modified during changes.</param>
        public OutlineControl(IPattern original, IPattern display)
        {
            _original = original;
            _pattern = display;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the pattern for this control
        /// </summary>
        public IPattern Pattern
        {
            get { return _pattern; }
            set
            {
                _pattern = value;
                UpdateOutlineControls();
            }
        }

        #endregion

        #region Private Functions

        private void UpdateOutlineControls()
        {
            _ignoreChanges = true;
            if (_pattern != null)
            {
                chkUseOutline.Checked = _pattern.UseOutline;
                if (_pattern.Outline != null)
                {
                    cbOutlineColor.Color = _pattern.Outline.GetFillColor();
                    sldOutlineOpacity.MaximumColor = cbOutlineColor.Color.ToOpaque();
                    sldOutlineOpacity.Value = cbOutlineColor.Color.GetOpacity();
                    dbxOutlineWidth.Value = _pattern.Outline.GetWidth();
                }
            }
            _ignoreChanges = false;
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Fires the OutlineChanged event
        /// </summary>
        protected virtual void OnOutlineChanged()
        {
            if (OutlineChanged != null) OutlineChanged(this, new EventArgs());
        }

        /// <summary>
        /// Fires the OutlineChanged event
        /// </summary>
        protected virtual void OnChangesApplied()
        {
            if (ChangesApplied != null) ChangesApplied(this, new EventArgs());
        }

        #endregion

        #region EventHandlers

        private void chkUseOutline_CheckedChanged(object sender, EventArgs e)
        {
            if (_ignoreChanges) return;
            if (_pattern != null)
            {
                _pattern.UseOutline = chkUseOutline.Checked;
            }
            OutlineChanged(this, new EventArgs());
        }

        private void btnEditOutline_Click(object sender, EventArgs e)
        {
            DetailedLineSymbolDialog dlg;
            if (_original != null)
            {
                dlg = new DetailedLineSymbolDialog(_pattern.Outline);
            }
            else if (_pattern != null)
            {
                dlg = new DetailedLineSymbolDialog(_pattern.Outline);
            }
            else
            {
                return;
            }
            dlg.ChangesApplied += DlgChangesApplied;
            dlg.ShowDialog();
        }

        private void DlgChangesApplied(object sender, EventArgs e)
        {
            UpdateOutlineControls();
            OnChangesApplied();
            OnOutlineChanged();
        }

        private void dbxOutlineWidth_TextChanged(object sender, EventArgs e)
        {
            if (_ignoreChanges) return;
            if (_pattern != null)
            {
                if (_pattern.Outline == null)
                {
                    _pattern.Outline = new LineSymbolizer(cbOutlineColor.Color, dbxOutlineWidth.Value);
                }
                else
                {
                    _pattern.Outline.SetWidth(dbxOutlineWidth.Value);
                }
            }

            OnOutlineChanged();
        }

        #endregion

        private void sldOutlineOpacity_ValueChanged(object sender, EventArgs e)
        {
            if (_ignoreChanges) return;
            if (_pattern != null)
            {
                _pattern.Outline.SetFillColor(_pattern.Outline.GetFillColor().ToTransparent((float)sldOutlineOpacity.Value));
            }
            cbOutlineColor.Color = sldOutlineOpacity.MaximumColor.ToTransparent((float)sldOutlineOpacity.Value);
            OnOutlineChanged();
        }

        private void cbOutlineColor_ColorChanged(object sender, EventArgs e)
        {
            if (_ignoreChanges) return;
            if (_pattern != null)
            {
                _pattern.Outline.SetFillColor(cbOutlineColor.Color);
            }
            sldOutlineOpacity.Value = cbOutlineColor.Color.GetOpacity();
            sldOutlineOpacity.MaximumColor = cbOutlineColor.Color.ToOpaque();
            OnOutlineChanged();
        }
    }
}