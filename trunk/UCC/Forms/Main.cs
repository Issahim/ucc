using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace UCC.Forms
{
    public partial class Main : Form
    {
        Classes.Profil profil = new Classes.Profil();

        public Main(Classes.Profil prof = null)
        {
            InitializeComponent();
            editActionNav.SelectedTab = generalActionPage;

            //cb_condTest.SelectedIndex = 0;

            if (prof != null)
            {
                profil = prof;
                refreshProfile();
                refreshActionLists();
            }
        }

        private void UCC_Load(object sender, EventArgs e)
        {
            
        }

        Classes.Action CurrentAction
        {
            get
            {
                return (Classes.Action)actionList.SelectedItem;
            }
        }

        Classes.Condition CurrentCondition
        {
            get
            {
                return (Classes.Condition)conditionsList.SelectedItem;
            }
        }

        Ressources.Moment CurrentMoment
        {
            get
            {
                if (rb_Combat.Checked)
                    return Ressources.Moment.Combat;
                if (rb_Pull.Checked)
                    return Ressources.Moment.Pull;
                if (rb_Patrol.Checked)
                    return Ressources.Moment.Patrol;
                return Ressources.Moment.Combat;
            }
        }



        void refreshProfile()
        {
        }


        void resetCondUI()
        {
        }


        void setCondUI()
        {
            resetCondUI();
        }

        private void cb_condTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCondUI();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.InitialDirectory = Global.confPath + @"\UCC";
            d.DefaultExt = "XML";
            d.Filter = "MyCC Profiles (*.xml)|*.xml";
            var result = d.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                profil = Classes.XmlSerializer.Deserialize<Classes.Profil>(d.FileName);
                refreshProfile();
                refreshActionLists();
            }
        }

        void refreshActionLists()
        {
            Classes.Action lastAction = CurrentAction;
            actionList.Items.Clear();
            switch (CurrentMoment)
            {
                case Ressources.Moment.Combat:
                    foreach (var act in profil.ActionsCombat)
                        actionList.Items.Add(act);
                    break;
                case Ressources.Moment.Pull:
                    foreach (var act in profil.ActionsPull)
                        actionList.Items.Add(act);
                    break;
                case Ressources.Moment.Patrol:
                    foreach (var act in profil.ActionsPatrol)
                        actionList.Items.Add(act);
                    break;
            }
            if (lastAction != null && actionList.Items.Contains(lastAction))
                actionList.SelectedItem = lastAction;
        }

        void refreshConditionsList()
        {
            Classes.Condition lastCondition = CurrentCondition;
            conditionsList.Items.Clear();
            foreach (var cond in CurrentAction.Conditions)
                conditionsList.Items.Add(cond);
            if (lastCondition != null && conditionsList.Items.Contains(lastCondition))
                actionList.SelectedItem = lastCondition;
        }

        void refreshAction()
        {
            refreshConditionsList();
        }

        private void combatList_SelectedValueChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = CurrentAction;
            refreshAction();
        }

        private void kryptonNavigator1_SelectedPageChanged(object sender, EventArgs e)
        {
            //refreshActionLists();
            //refreshAction();
            clearSeletectedInLists();
        }

        void clearSeletectedInLists()
        {
            actionList.ClearSelected();
            actionList.SelectedIndex = -1;
            actionList.SelectedIndex = -1;
            actionList.ClearSelected();
        }

        private void BupAction_Click(object sender, EventArgs e)
        {
            profil.UpAction(CurrentAction, CurrentMoment);
            refreshActionLists();

        }

        private void BDownAction_Click(object sender, EventArgs e)
        {
            profil.DownAction(CurrentAction, CurrentMoment);
            refreshActionLists();
        }

        private void BAddAction_Click(object sender, EventArgs e)
        {
            var newAction = Forms.CreateInstance.Show(typeof(Classes.Action), Global.Actions) as Classes.Action;
            if (newAction != null)
            {
                profil.getActionList(CurrentMoment).Add(newAction);
                refreshActionLists();
            }
        }

        private void b_AddCond_Click(object sender, EventArgs e)
        {
            var newCond = Forms.CreateInstance.Show(typeof(Classes.Condition), Global.Conditions) as Classes.Condition;
            if (newCond != null)
            {
                CurrentAction.Conditions.Add(newCond);
                refreshConditionsList();
            }
        }

        private void BRemoveAction_Click(object sender, EventArgs e)
        {
            var MBR = MessageBox.Show("Are you sure ?", "Confirm", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);

            if (MBR == System.Windows.Forms.DialogResult.Yes)
            {
                if (CurrentAction != null)
                {
                    profil.getActionList(CurrentMoment).Remove(CurrentAction);
                    refreshActionLists();
                }
            }
        }

        private void b_RemoveCond_Click(object sender, EventArgs e)
        {
            if (CurrentCondition != null)
            {
                if (CurrentAction.Conditions.Contains(CurrentCondition))
                {
                    CurrentAction.Conditions.Remove(CurrentCondition);
                    refreshConditionsList();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (actionList.SelectedIndex == -1 || actionList.SelectedItem == null)
                editActionNav.Visible = false;
            else
                editActionNav.Visible = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.InitialDirectory = Global.confPath + @"\UCC";
            d.DefaultExt = "XML";
            d.Filter = "MyCC Profiles (*.xml)|*.xml";
            var result = d.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Classes.XmlSerializer.Serialize(d.FileName, profil);
                Global.settings.lastCCPath = d.FileName;
                Classes.Settings.save();
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            profil = new Classes.Profil();
            refreshProfile();
            refreshActionLists();
        }

        private void bCLose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_Val_DropDown(object sender, EventArgs e)
        {
        }

        private void tb_Special_DropDown(object sender, EventArgs e)
        {
        }

        private void tb_Val_DropDownClosed(object sender, EventArgs e)
        {
        }

        private void attackTarget_Click(object sender, EventArgs e)
        {
            
        }

        private void BWizard_Click(object sender, EventArgs e)
        {
        }

        Classes.Action clipboard = null;
        private void BCopy_Click(object sender, EventArgs e)
        {
            clipboard = CurrentAction.Clone();
            MessageBox.Show("Action added to clipboard !");
        }

        private void BCPAdd_Click(object sender, EventArgs e)
        {
            if (clipboard == null)
            {
                MessageBox.Show("Clipboard is empty !");
                return;
            }
            String name = Forms.InputBox.Show("Action name : ", "New Action", "New Action");
            if (name != "")
            {
                clipboard.ActionName = name;
                profil.getActionList(CurrentMoment).Add(clipboard);
                refreshActionLists();
                actionList.SelectedIndex = actionList.Items.Count - 1;
            }
        }

        private void UCCAlgo_Click(object sender, EventArgs e)
        {
            Algo.Show();
        }

        private void conditionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void combosList_SelectedValueChanged(object sender, EventArgs e)
        {
            refreshAction();
        }

        private void propertyGrid1_PropertyValueChanged(object sender, EventArgs e)
        {
            refreshActionLists();
        }

        private void rb_Patrol_CheckedChanged(object sender, EventArgs e)
        {
            refreshActionLists();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }

        private void conditionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid2.SelectedObject = CurrentCondition;
        }

        private void propertyGrid2_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            conditionsList.Refresh();
        }
    }
}