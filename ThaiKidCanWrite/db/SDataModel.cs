using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LDWordProcessor.db
{
    class Mapinput
    {
        public Panel picture { get; set; }
        public Panel picture_top { get; set; }
        public Panel map_panel { get; set; }
        public string map_type { get; set; }
        public TextBox input_title { get; set; }
        public TextBox input_1 { get; set; }
        public TextBox input_2 { get; set; }
        public TextBox input_3 { get; set; }
        public TextBox input_4 { get; set; }
        public TextBox input_5 { get; set; }
        public TextBox input_6 { get; set; }
        public TextBox input_7 { get; set; }
        public TextBox input_8 { get; set; }
        public TextBox input_9 { get; set; }
        public TextBox input_10 { get; set; }
        public TextBox input_11 { get; set; }
        public TextBox input_12 { get; set; }
        public Label label_1 { get; set; }
        public Label label_2 { get; set; }
        public Label label_3 { get; set; }
        public Label label_4 { get; set; }
        public Label label_5 { get; set; }
        public Label label_6 { get; set; }
        public Label label_7 { get; set; }
        public Label label_8 { get; set; }
        public Label label_9 { get; set; }
        public Label label_10 { get; set; }
        public Label label_11 { get; set; }
        public Label label_12 { get; set; }
    }
    class SAnswer
    {
        private string _mid;
        public string mid
        {
            get { return _mid; }
            set { _title = value; }
        }
        
        private string _mapid;
        public string mapid
        {
            get { return _mapid; }
            set { _mapid = value; }
        }
        
        private string _title;
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _q1;
        public string q1
        {
            get { return _q1; }
            set { _q1 = value; }
        }

        private string _q2;
        public string q2
        {
            get { return _q2; }
            set { _q2 = value; }
        }

        private string _q3;
        public string q3
        {
            get { return _q3; }
            set { _q3 = value; }
        }

        private string _q4;
        public string q4
        {
            get { return _q4; }
            set { _q4 = value; }
        }

        private string _q5;
        public string q5
        {
            get { return _q5; }
            set { _q5 = value; }
        }

        private string _q6;
        public string q6
        {
            get { return _q6; }
            set { _q6 = value; }
        }

        private string _q7;
        public string q7
        {
            get { return _q7; }
            set { _q7 = value; }
        }

        private string _q8;
        public string q8
        {
            get { return _q8; }
            set { _q8 = value; }
        }

        private string _q9;
        public string q9
        {
            get { return _q9; }
            set { _q9 = value; }
        }

        private string _q10;
        public string q10
        {
            get { return _q10; }
            set { _q10 = value; }
        }

        private string _q11;
        public string q11
        {
            get { return _q11; }
            set { _q11 = value; }
        }

        private string _q12;
        public string q12
        {
            get { return _q12; }
            set { _q12 = value; }
        }

        private string _send;
        public string send
        {
            get { return _send; }
            set { _send = value; }
        }
        
    }
}
