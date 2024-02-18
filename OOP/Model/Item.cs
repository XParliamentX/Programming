using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOP.Sevices;
namespace OOP.Model
{
    internal class Item
    {
        private static int id_counter = 0;
        private readonly int _id;
        private bool ChekError = true;
        private string _name;
        private string _info;
        private float _cost;


        public int Id => _id;
        public bool CheckError { get; set;}
        public string Name
        {
            get => _name;
            set
            {
                ChekError = ValueValidator.AssertStringOnLenght(value, 200, nameof(Name));
            }
        }
        public float Cost
        {
            get => _cost;
            set
            {
                ChekError = ValueValidator.
            }

        }
        public string Info => _info;

    }
}
