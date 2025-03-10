﻿using Presentation.Interfaces;
using Presentation.UI;

namespace Presentation.Wrappers
{
    public class TabPatternMatching : TabController 
    {
        private Label label_currentDirectory;
        private Label label_patternMatching_to;
        private TextBox textBox_Pattern_to;
        private TextBox textBox_pattern_from;
        private ComboBox comboBox_patternMatching_operation;

        public TabPatternMatching(
            Label label_currentDirectory, 
            Label label_patternMatching_to, 
            TextBox textBox_Pattern_to, 
            TextBox textBox_pattern_from, 
            ComboBox comboBox_patternMatching_operation, 
            DataGridView_Files dataGridView_preview, 
            DataGridView_Files dataGridView_selection, 
            TabPage tabPage_patternMatching)
            :base(dataGridView_preview,dataGridView_selection,tabPage_patternMatching, label_currentDirectory)
        {
            this.label_currentDirectory = label_currentDirectory;
            this.label_patternMatching_to = label_patternMatching_to;
            this.textBox_Pattern_to = textBox_Pattern_to;
            this.textBox_pattern_from = textBox_pattern_from;
            this.comboBox_patternMatching_operation = comboBox_patternMatching_operation;
        }

        public override IOperationContract GetTabContent()
        {
            throw new NotImplementedException();
        }
    }
}
