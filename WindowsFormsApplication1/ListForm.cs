using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Model;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #region Serialize

        //создание экземпляра JsonSerializer
        JsonSerializer serializer = new JsonSerializer()
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Include
        };

        //Сериализация 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ElementList.listElement.Count == 0)
            {
                MessageBox.Show("Список пуст");
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Json Files (*.json)|*.json";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    serializer.Serialize(jw, ElementList.listElement);
                }

                MessageBox.Show("Сохранено");
            }
        }
        //Десериализация
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Json Files (*.json)|*.json";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFile.FileName))
                using (JsonReader jr = new JsonTextReader(sr))
                {
                    ElementList.listElement = (List<IElement>) serializer.Deserialize(jr, typeof(List<IElement>));
                    dataGridViewList.Rows.Clear();
                    foreach(var data in ElementList.listElement)
                    {
                        dataGridViewList.Rows.Add(data.Name, data.Value);
                    }
                }
            }
        }

        #endregion

        #region Button's
        //Описание кнопки расчета импеданса

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxFrequency.Text == "")
            {
                MessageBox.Show("Введите частоту");
            }
            else
            {
                double freq = Convert.ToDouble(textBoxFrequency.Text);
                if (freq < 0)
                {
                    MessageBox.Show("Введите положительную частоту");
                }
                else if (this.dataGridViewList.Rows.Count < 2)
                {
                    MessageBox.Show("Список пуст");
                }
                else
                {
                    for (int i = 0; i < this.dataGridViewList.Rows.Count - 1; i++)
                    {
                        IElement element = ElementList.listElement[i];
                        this.dataGridViewList.Rows[i].Cells[2].Value =
                            Convert.ToString(element.GetImpedance(Convert.ToDouble(textBoxFrequency.Text)));
                    }
                }
            }
        }

        #region поэлементный расчет импеданса
        ////Описание кнопки расчета импеданса
        //private void buttonCalculate_Click(object sender, EventArgs e)
        //{
        //    int CalculateRowIndex = dataGridViewList.CurrentCell.RowIndex;
        //    IElement element = ElementList.listElement[CalculateRowIndex];

        //    if ((textBoxFrequency.Text == "") && !(element is Model.Resistor))
        //    {
        //        MessageBox.Show("Введите частоту");
        //    }                                                                         

        //    else if ((element is Model.Resistor) && (textBoxFrequency.Text != ""))    
        //    {
        //        MessageBox.Show("Импеданс для резистора считается без учёта частоты");
        //    }

        //    else if ((element is Model.Resistor) && (textBoxFrequency.Text == ""))
        //    {
        //        dataGridViewList[2, CalculateRowIndex].Value = element.GetImpedance(0);
        //    }

        //    else
        //    {
        //        dataGridViewList[2, CalculateRowIndex].Value = element.GetImpedance(Convert.ToDouble(textBoxFrequency.Text));
        //    }
        //}
        #endregion

        //Описание кнопки добавления элемента
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
                ElementInfoForm Form1 = new ElementInfoForm();
            if (Form1.ShowDialog() == DialogResult.OK)
            {
                var element = Form1.Element;
                this.dataGridViewList.Rows.Add(element.Name, element.Value);
                ElementList.listElement.Add(element);
            }      
        }
        
        //Описание кнопки удаления
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int removeIndex = dataGridViewList.CurrentCell.RowIndex;
            if (dataGridViewList.Rows.Count == 0)
            {
                MessageBox.Show("Список пуст");
            }
            dataGridViewList.Rows.RemoveAt(removeIndex);
            ElementList.listElement.RemoveAt(removeIndex);
        }

        //Описание кнопки изменения данных через calculateform
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.Rows.Count == 0)
            {
                MessageBox.Show("Список пуст");
            }
            else
            {
                ElementInfoForm ModifyForm = new ElementInfoForm();
                int ModifyIndex = dataGridViewList.CurrentCell.RowIndex;
                ModifyForm.Element = ElementList.listElement[ModifyIndex];
                if (ModifyForm.ShowDialog() == DialogResult.OK)
                {
                    var newElement = ModifyForm.Element;
                    ElementList.listElement.Insert(dataGridViewList.SelectedCells[0].RowIndex, newElement);
                    ElementList.listElement.RemoveAt(dataGridViewList.SelectedCells[0].RowIndex + 1);
                    dataGridViewList.Rows.Clear();
                    foreach (var data in ElementList.listElement)
                    {
                        dataGridViewList.Rows.Add(data.Name, data.Value);
                    }                                 
                }   
            }
        }

        #endregion

    }
}
