using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LDWordProcessor
{
    public class SWorkModel
    {
        private string _id,_step, _title, _q1, _q2, _q3, _q4, _q5, _q6, _q7, _q8, _q9, _q10, _q11, _q12, _send, _date_create, _date_update, _mid, _mapid;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string step
        {
            get { return _step; }
            set { _step = value; }
        }
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string q1
        {
            get { return _q1; }
            set { _q1 = value; }
        }
        public string q2
        {
            get { return _q2; }
            set { _q2 = value; }
        }
        public string q3
        {
            get { return _q3; }
            set { _q3 = value; }
        }
        public string q4
        {
            get { return _q4; }
            set { _q4 = value; }
        }
        public string q5
        {
            get { return _q5; }
            set { _q5 = value; }
        }
        public string q6
        {
            get { return _q6; }
            set { _q6 = value; }
        }
        public string q7
        {
            get { return _q7; }
            set { _q7 = value; }
        }
        public string q8
        {
            get { return _q8; }
            set { _q8 = value; }
        }
        public string q9
        {
            get { return _q9; }
            set { _q9 = value; }
        }
        public string q10
        {
            get { return _q10; }
            set { _q10 = value; }
        }
        public string q11
        {
            get { return _q11; }
            set { _q11 = value; }
        }
        public string q12
        {
            get { return _q12; }
            set { _q12 = value; }
        }
        public string send
        {
            get { return _send; }
            set { _send = value; }
        }
        public string date_create
        {
            get { return _date_create; }
            set { _date_create = value; }
        }
        public string date_update
        {
            get { return _date_update; }
            set { _date_update = value; }
        }
        public string mid
        {
            get { return _mid; }
            set { _mid = value; }
        }
        public string mapid
        {
            get { return _mapid; }
            set { _mapid = value; }
        }
    }
    public class SWorkDetailModel
    {
        private string _id, _wid, _sentent, _type;
        private int _order;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string wid
        {
            get { return _wid; }
            set { _wid = value; }
        }
        public string sentent
        {
            get { return _sentent; }
            set { _sentent = value; }
        }
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int order
        {
            get { return _order; }
            set { _order = value; }
        }
    
    }

}
