﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class CarReport {
        public DateTime Date { get; set; } //日付
        public string Auther { get; set; } //記録者
        public MakeGroup Maker { get; set; } //メーカー
        public string CarName { get; set; } //車名
        public string Report { get; set; } //レポート
        public Image Picture { get; set; } //画像




        //メーカー
        public enum MakeGroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他
        }


        //引数付きコンストラクタ
        //public CarReport(DateTime date, string auther, MakeGroup maker, 
        //                 string carname, string report, Image picture ) {

        //    this.Date = date;
        //    this.Auther = auther;
        //    this.Maker = maker;
        //    this.CarName = carname;
        //    this.Report = report;
        //    this.Picture = picture;
         
        //}

    }
}