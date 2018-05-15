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

        public ElementInfoForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #region _masked сheck
        //проверка заполнения строк
        private bool _maskedName = false;
        private bool _maskedValue = false;

        #endregion

        #region Element

        private IElement _element;

        //Описание данных элемента
        public IElement Element
        {
            get
            {
                if (radioButtonInductor.Checked)
                {
                    var Inductor = new Model.Inductor();
                    Inductor.Name = Convert.ToString(textBoxName.Text);
                    Inductor.Value = Convert.ToDouble(textBoxValue.Text);
                    _element = Inductor;
                }
                else if (radioButtonResistor.Checked)
                {
                    var Resistor = new Model.Resistor();
                    Resistor.Name = Convert.ToString(textBoxName.Text);
                    Resistor.Value = Convert.ToDouble(textBoxValue.Text);
                    _element = Resistor;
                }
                else if (radioButtonCapacitor.Checked)
                {
                    var Capacitor = new Model.Capacitor();
                    Capacitor.Name = Convert.ToString(textBoxName.Text);
                    Capacitor.Value = Convert.ToDouble(textBoxValue.Text);
                    _element = Capacitor;
                }
                return _element;
            }

            set
            {
                _element = value;
                textBoxName.Text = Convert.ToString(value.Name);
                textBoxValue.Text = Convert.ToString(value.Value);
            }
        }
        #endregion

        #region button's
        // кнопка отмены 
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        // кнопка ОК
        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool a = false;
            if ((textBoxName.Text != "") || (textBoxValue.Text != ""))
            {
                a = true;
            }

            if(!(_maskedName && _maskedValue) && !(a))
            {
                MessageBox.Show("Введите навзание элемента и его значение");
            }
            if(a)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

       
        #endregion

    }
}
