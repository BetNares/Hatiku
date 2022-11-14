using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views.EventView;


namespace Hatiku.Views.DataView
{
    public interface IDiseaseDiagnosisHistory: IEventView
    {
        int Age { get; set;  }
        int Height { get; set; }
        float Weight { get; set; }
        string Gender { get; set; }
        int ApHi { get; set; }
        int ApLo { get; set; }
        string Cholesterol { get; set; }
        string Glucose { get; set; }
        bool Smoking { get; set; }
        bool Alcohol { get; set; }
        bool Active { get; set; }
        bool DiseaseResult { get; set; }

        void SetDiseaseHistoryBindingSource(BindingSource diseaseHistoryBindingSource);
    }
 }
