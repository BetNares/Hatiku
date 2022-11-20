using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hatiku.Forms { 
    public partial class InputDataForm : Form
    {
        private Dictionary<string, string> ExpertSystemInput = new Dictionary<string, string>();
        private Dictionary<string, string> MachineLearningInput = new Dictionary<string, string>();



        public InputDataForm()
        {
            InitializeComponent();

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputFetch(object sender, EventArgs e)
        {

            MachineLearningInput["key"] = "value";

            MachineLearningInput.Add("age", inputAge.Text);
            MachineLearningInput.Add("gender", inputGender.Text);
            MachineLearningInput.Add("height", inputHeight.Text);
            MachineLearningInput.Add("weight", inputWeight.Text);
            MachineLearningInput.Add("ap_hi", inputAPHigh.Text);
            MachineLearningInput.Add("ap_lo", inputAPLow.Text);
            MachineLearningInput.Add("cholesterol", inputCholesterol.Text);
            MachineLearningInput.Add("gluc", inputGlucose.Text);
            MachineLearningInput.Add("smoke", inputSmoke.Text);
            MachineLearningInput.Add("alco", inputAlcohol.Text);
            MachineLearningInput.Add("active", inputActive.Text);
            MachineLearningInput.Add("racial_identity", InputRacialIdentity.Text);

            ExpertSystemInput["key"] = "value";


            if (blood_clotting_disorder1.Checked)
                ExpertSystemInput.Add("blood_clotting_disorder", "1");
            else if (blood_clotting_disorder0.Checked)
                ExpertSystemInput.Add("blood_clotting_disorder", "0");

            if (kidney_disease1.Checked)
                ExpertSystemInput.Add("kidney_disease", "1");
            else if (kidney_disease0.Checked)
                ExpertSystemInput.Add("kidney_disease", "0");

            if (chest_pains1.Checked)
                ExpertSystemInput.Add("chest_pains", "1");
            else if (chest_pains0.Checked)
                ExpertSystemInput.Add("chest_pains", "0");

            if (breathlessness1.Checked)
                ExpertSystemInput.Add("breathlessness", "1");
            else if (breathlessness0.Checked)
                ExpertSystemInput.Add("breathlessness", "0");

            if (nausea1.Checked)
                ExpertSystemInput.Add("nausea", "1");
            else if (nausea0.Checked)
                ExpertSystemInput.Add("nausea", "0");

            if (faintings1.Checked)
                ExpertSystemInput.Add("faintings", "1");
            else if (faintings0.Checked)
                ExpertSystemInput.Add("faintings", "0");

            if (fatigue1.Checked)
                ExpertSystemInput.Add("fatigue", "1");
            else if (fatigue0.Checked)
                ExpertSystemInput.Add("fatigue", "0");

            if (swollen_ankles1.Checked)
                ExpertSystemInput.Add("swollen_ankles", "1");
            else if (swollen_ankles0.Checked)
                ExpertSystemInput.Add("swollen_ankles", "0");

            if (drastic_weight_changes1.Checked)
                ExpertSystemInput.Add("drastic_weight_changes", "1");
            else if (drastic_weight_changes0.Checked)
                ExpertSystemInput.Add("drastic_weight_changes", "0");

            if (bloating1.Checked)
                ExpertSystemInput.Add("bloating", "1");
            else if (bloating0.Checked)
                ExpertSystemInput.Add("bloating", "0");

            if (loss_of_appetite1.Checked)
                ExpertSystemInput.Add("loss_of_appetite", "1");
            else if (loss_of_appetite0.Checked)
                ExpertSystemInput.Add("loss_of_appetite", "0");

            if (dizziness_confusion1.Checked)
                ExpertSystemInput.Add("dizziness_confusion", "1");
            else if (dizziness_confusion0.Checked)
                ExpertSystemInput.Add("dizziness_confusion", "0");

            if (palpitations1.Checked)
                ExpertSystemInput.Add("palpitations", "1");
            else if (palpitations0.Checked)
                ExpertSystemInput.Add("palpitations", "0");

            if (atrial_fibrillation1.Checked)
                ExpertSystemInput.Add("atrial_fibrillation", "1");
            else if (atrial_fibrillation0.Checked)
                ExpertSystemInput.Add("atrial_fibrillation", "0");

            if (sudden_headache1.Checked)
                ExpertSystemInput.Add("sudden_headache", "1");
            else if (sudden_headache0.Checked)
                ExpertSystemInput.Add("sudden_headache", "0");

            if (sudden_lossofvision1.Checked)
                ExpertSystemInput.Add("sudden_lossofvision", "1");
            else if (sudden_lossofvision0.Checked)
                ExpertSystemInput.Add("sudden_lossofvision", "0");

            if (face_dropping1.Checked)
                ExpertSystemInput.Add("face_dropping", "1");
            else if (face_dropping0.Checked)
                ExpertSystemInput.Add("face_dropping", "0");

            if (numbness1.Checked)
                ExpertSystemInput.Add("numbness", "1");
            else if (numbness0.Checked)
                ExpertSystemInput.Add("numbness", "0");

            if (speech_problem1.Checked)
                ExpertSystemInput.Add("speech_problem", "1");
            else if (speech_problem0.Checked)
                ExpertSystemInput.Add("speech_problem", "0");

            if (leg_pain_cramping1.Checked)
                ExpertSystemInput.Add("leg_pain_cramping", "1");
            else if (leg_pain_cramping0.Checked)
                ExpertSystemInput.Add("leg_pain_cramping", "0");

            if (burning_aching_toes1.Checked)
                ExpertSystemInput.Add("burning_aching_toes", "1");
            else if (burning_aching_toes0.Checked)
                ExpertSystemInput.Add("burning_aching_toes", "0");

            if (cool_feet_skin1.Checked)
                ExpertSystemInput.Add("cool_feet_skin", "1");
            else if (cool_feet_skin0.Checked)
                ExpertSystemInput.Add("cool_feet_skin", "0");

            if (redness_colorchanges_skin1.Checked)
                ExpertSystemInput.Add("redness_colorchanges_skin", "1");
            else if (redness_colorchanges_skin0.Checked)
                ExpertSystemInput.Add("redness_colorchanges_skin", "0");

            if (back_pain1.Checked)
                ExpertSystemInput.Add("back_pain", "1");
            else if (back_pain0.Checked)
                ExpertSystemInput.Add("back_pain", "0");

            if (coughing1.Checked)
                ExpertSystemInput.Add("coughing", "1");
            else if (coughing0.Checked)
                ExpertSystemInput.Add("coughing", "0");

            if (hoarseness1.Checked)
                ExpertSystemInput.Add("hoarseness", "1");
            else if (hoarseness0.Checked)
                ExpertSystemInput.Add("hoarseness", "0");

            if (tenderness_pain_chest1.Checked)
                ExpertSystemInput.Add("tenderness_pain_chest", "1");
            else if (tenderness_pain_chest0.Checked)
                ExpertSystemInput.Add("tenderness_pain_chest", "0");

            if (sharp_sudden_pain_upperback1.Checked)
                ExpertSystemInput.Add("sharp_sudden_pain_upperback", "1");
            else if (sharp_sudden_pain_upperback0.Checked)
                ExpertSystemInput.Add("sharp_sudden_pain_upperback", "0");

            if (pain_chest_jaw_neck_arms1.Checked)
                ExpertSystemInput.Add("pain_chest_jaw_neck_arms", "1");
            else if (pain_chest_jaw_neck_arms0.Checked)
                ExpertSystemInput.Add("pain_chest_jaw_neck_arms", "0");

            if (loss_of_consciousness1.Checked)
                ExpertSystemInput.Add("loss_of_consciousness", "1");
            else if (loss_of_consciousness0.Checked)
                ExpertSystemInput.Add("loss_of_consciousness", "0");

            if (difficulty_breathing1.Checked)
                ExpertSystemInput.Add("difficulty_breathing", "1");
            else if (difficulty_breathing0.Checked)
                ExpertSystemInput.Add("difficulty_breathing", "0");

            if (trouble_swallowing_food1.Checked)
                ExpertSystemInput.Add("trouble_swallowing_food", "1");
            else if (trouble_swallowing_food0.Checked)
                ExpertSystemInput.Add("trouble_swallowing_food", "0");

            if (deep_constant_belly_pain1.Checked)
                ExpertSystemInput.Add("deep_constant_belly_pain", "1");
            else if (deep_constant_belly_pain0.Checked)
                ExpertSystemInput.Add("deep_constant_belly_pain", "0");

            if (family_history_coronaryheartdisease1.Checked)
                ExpertSystemInput.Add("family_history_coronaryheartdisease", "1");
            else if (family_history_coronaryheartdisease0.Checked)
                ExpertSystemInput.Add("family_history_coronaryheartdisease", "0");

            if (personal_family_history_blood_bloodvesseldisease1.Checked)
                ExpertSystemInput.Add("personal_family_history_blood_bloodvesseldisease", "1");
            else if (personal_family_history_blood_bloodvesseldisease0.Checked)
                ExpertSystemInput.Add("personal_family_history_blood_bloodvesseldisease", "0");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
