using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public partial class ElementInfoForm : Form
    {

        #region forms
        private ObjectControl elementControl = new ObjectControl();
        public IElement Element;

        //add
        public ElementInfoForm()
        {
            InitializeComponent();
        
            elementControl.Parent = elementInfoGroupBox;            
            elementControl.Location = new Point(2, 2);
            elementControl.Size = new Size(325, 90);
            elementControl.readOnly = false;
        }
        
        //modify
        public ElementInfoForm(int rowNumber, ElementList list)
        {
            InitializeComponent();
            elementControl.Parent = elementInfoGroupBox;
            elementControl.Location = new Point(2, 2);
            elementControl.Size = new Size(325, 90);
            elementControl.readOnly = true;
        }
        #endregion

        #region button's
        // кнопка отмены 
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Element = null;
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        // кнопка ОК
        private void buttonOK_Click(object sender, EventArgs e)
        {
                Element = elementControl.elementControl;
                this.DialogResult = DialogResult.OK;
                Close();
        }

       
        #endregion

    }
}
