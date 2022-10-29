using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Hatiku.Models
{
    public class DiseaseDiagnosisHistory
    {
        private DateTime _histId;
        private int _age;
        private int _height;
        private float _weight;
        private string _gender;
        private int _ap_hi;
        private int _ap_lo;
        private string _cholesterol;
        private string _glucose;
        private bool _smoking;
        private bool _alcohol;
        private bool _active;
        private bool _diseaseResult;

        [DisplayName("Disease Diagnosis Id")]
        [Key]
        public DateTime HistId { get => _histId; set => _histId = value; }

        public int Age { get => _age; set => _age = value; }
        public int Height { get => _height; set => _height = value; }
        public float Weight { get => _weight; set => _weight = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int ApHi { get => _ap_hi; set => _ap_hi = value;}
        public int ApLo { get => _ap_lo; set => _ap_lo = value;}
        public string Cholesterol { get => _cholesterol; set => _cholesterol = value; }
        public string Glucose { get => _glucose; set => _glucose = value;}
        public bool Smoking { get => _smoking; set => _smoking = value; }
        public bool Alcohol { get => _alcohol; set => _alcohol = value; }
        public bool Active { get => _active; set => _active = value; }
        public bool DiseaseResult { get => _diseaseResult; set => _diseaseResult = value; }

    }
}
