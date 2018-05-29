using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;

namespace WindowsFormsApplication1
{
    public partial class ObjectControl : UserControl
    {
        public ObjectControl()
        {
            InitializeComponent();
        }

        #region IElement
        private IElement _elementControl;
        public IElement elementControl
        {
            get
            {
                if (radioButtonInductor.Checked)
                {
                    var Inductor = new Model.Inductor();
                    Inductor.Name = Convert.ToString(textBoxName.Text);
                    Inductor.Value = Convert.ToDouble(textBoxValue.Text);
                    _elementControl = Inductor;
                }
                else if (radioButtonResistor.Checked)
                {
                    var Resistor = new Model.Resistor();
                    Resistor.Name = Convert.ToString(textBoxName.Text);
                    Resistor.Value = Convert.ToDouble(textBoxValue.Text);
                    _elementControl = Resistor;
                }
                else if (radioButtonCapacitor.Checked)
                {
                    var Capacitor = new Model.Capacitor();
                    Capacitor.Name = Convert.ToString(textBoxName.Text);
                    Capacitor.Value = Convert.ToDouble(textBoxValue.Text);
                    _elementControl = Capacitor;
                }
                return _elementControl;
            }

            set
            {
                _elementControl = value;
                textBoxName.Text = Convert.ToString(value.Name);
                textBoxValue.Text = Convert.ToString(value.Value);
                if (_elementControl is Resistor)
                {
                    radioButtonResistor.Checked = true;
                }
                else if (_elementControl is Capacitor)
                {
                    radioButtonCapacitor.Checked = true;
                } 
                else if (_elementControl is Inductor)
                {
                    radioButtonInductor.Checked = true;
                }
            }
        }
        #endregion

        #region ReadOnly

        private bool _readOnly;

        public bool readOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;
                if (_readOnly && elementControl is Model.Resistor)
                {
                    textBoxValue.ReadOnly = true;
                    textBoxName.ReadOnly = true;
                    radioButtonResistor.Enabled = true;
                    radioButtonInductor.Enabled = false;
                    radioButtonCapacitor.Enabled = false;
                }
                else if(_readOnly && elementControl is Model.Inductor)
                {
                    textBoxValue.ReadOnly = false;
                    textBoxName.ReadOnly = false;
                    radioButtonResistor.Enabled = false;
                    radioButtonInductor.Enabled = true;
                    radioButtonCapacitor.Enabled = false;
                }
                else if (_readOnly && elementControl is Model.Capacitor)
                {
                    textBoxValue.ReadOnly = false;
                    textBoxName.ReadOnly = false;
                    radioButtonResistor.Enabled = false;
                    radioButtonInductor.Enabled = false;
                    radioButtonCapacitor.Enabled = true;
                }
                else if(!_readOnly)
                {
                    textBoxName.ReadOnly = false;
                    textBoxValue.ReadOnly = false;
                    radioButtonResistor.Enabled = true;
                    radioButtonInductor.Enabled = true;
                    radioButtonCapacitor.Enabled = true;
                }                
                
            }
        }


        #endregion
    }
 }
