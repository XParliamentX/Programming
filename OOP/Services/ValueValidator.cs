using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Model;

namespace OOP.Services
{
    public static class ValueValidator
    {
        public static bool AssertStringOnLenght(string value , int MaxLength , string PropertyName)
        {
            if (value.Length > MaxLength)
            {
                string caption = "Ошибка";
                string message = $"{PropertyName} должен быть меньше {MaxLength} символов";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool AssertCostOnZero(double value)
        {
            if (value < 0)
            {
                string caption = "Ошибка";
                string message = "Цена товара не может быть меньше или ровна 0";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    return false;
                }
            }
            return true;
        }
    }
}