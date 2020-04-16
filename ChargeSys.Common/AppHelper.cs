using ChargeSys.Common.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeSys.Common
{
    public class AppHelper
    {
        private static AppHelper _appHelper = null;
        //配置文件夹路径
        public static string ConfigFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs");

        public static string DbConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs", "DbConfig.json");

        public static string SettingPath = AppDomain.CurrentDomain.BaseDirectory + @"\SysxConfig\SettingConfig.json";
        public static string PrintConfigPath = AppDomain.CurrentDomain.BaseDirectory + @"\SysxConfig\PrintConfig.json";
        public static string LogFolder = AppDomain.CurrentDomain.BaseDirectory + @"SysxLog\";  //日志文件夹路径
        public static Form MainForm = null;
        public static List<KVEntity> DefineTpye = new List<KVEntity>();
        public static DbInfo DbSetting = null;
        public static SettingEntity AppSetting = new SettingEntity();
        public static PrintPoint PointSetting = new PrintPoint();

        public static volatile object AppLocker = new object();
        static AppHelper()
        {
            if (!Directory.Exists(ConfigFolder))
                Directory.CreateDirectory(ConfigFolder);
            if (!Directory.Exists(LogFolder))
                Directory.CreateDirectory(LogFolder);
            if (!File.Exists(SettingPath))
            {
                File.WriteAllText(SettingPath, JsonConvert.SerializeObject(new SettingEntity(), Formatting.Indented));
            }
            if (!File.Exists(PrintConfigPath))
            {
                File.WriteAllText(PrintConfigPath, JsonConvert.SerializeObject(new SettingEntity(), Formatting.Indented));
            }
            _appHelper = new AppHelper();
        }
        private AppHelper()
        {
            InitConfig();
            InitDefine();
        }

        public static AppHelper GetInstance()
        {
            return _appHelper;
        }

        private void InitDefine()
        {
            //号牌种类
            DefineTpye.Add(new KVEntity() { Key = "小型汽车", Val = "02", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型汽车", Val = "01", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "警用汽车", Val = "23", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "使馆汽车", Val = "03", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "领馆汽车", Val = "04", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "境外汽车", Val = "05", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "外籍汽车", Val = "06", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "教练汽车", Val = "16", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "试验汽车", Val = "18", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "农用运输车", Val = "13", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "拖拉机", Val = "14", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "挂车", Val = "15", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "临时入境汽车", Val = "20", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "临时行驶车", Val = "22", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "两、三轮摩托车", Val = "07", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻便摩托车", Val = "08", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "使馆摩托车", Val = "09", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "领馆摩托车", Val = "10", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "境外摩托车", Val = "11", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "外籍摩托车", Val = "12", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "教练摩托车", Val = "17", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "试验摩托车", Val = "19", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "临时入境摩托车", Val = "21", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "警用摩托", Val = "24", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型新能源汽车", Val = "51", DefineType = "HPZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型新能源汽车", Val = "52", DefineType = "HPZL" });

            //车辆种类
            DefineTpye.Add(new KVEntity() { Key = "重型普通半挂车", Val = "B11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型厢式半挂车", Val = "B12", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型罐式半挂车", Val = "B13", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型平板半挂车", Val = "B14", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型集装箱半挂车", Val = "B15", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型自卸半挂车", Val = "B16", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型特殊结构半挂车", Val = "B17", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型仓栅式半挂车", Val = "B18", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型旅居半挂车", Val = "B19", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型专项作业半挂车", Val = "B1A", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型低平板半挂车", Val = "B1B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型车辆运输半挂车", Val = "B1C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型罐式自卸半挂车", Val = "B1D", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型平板自卸半挂车", Val = "B1E", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型集装箱自卸半挂车", Val = "B1F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型特殊结构自卸半挂车", Val = "B1G", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型仓栅式自卸半挂车", Val = "B1H", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型专项作业自卸半挂车", Val = "B1J", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型低平板自卸半挂车", Val = "B1K", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型中置轴旅居挂车", Val = "B1U", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型中置轴车辆运输车", Val = "B1V", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型中置轴普通挂车", Val = "B1W", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型普通半挂车", Val = "B21", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型厢式半挂车", Val = "B22", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型罐式半挂车", Val = "B23", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型平板半挂车", Val = "B24", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型集装箱半挂车", Val = "B25", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型自卸半挂车", Val = "B26", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型特殊结构半挂车", Val = "B27", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型仓栅式半挂车", Val = "B28", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型旅居半挂车", Val = "B29", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型专项作业半挂车", Val = "B2A", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型低平板半挂车", Val = "B2B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型车辆运输半挂车", Val = "B2C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型罐式自卸半挂车", Val = "B2D", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型平板自卸半挂车", Val = "B2E", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型集装箱自卸半挂车", Val = "B2F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型特殊结构自卸半挂车", Val = "B2G", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型仓栅式自卸半挂车", Val = "B2H", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型专项作业自卸半挂车", Val = "B2J", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型低平板自卸半挂车", Val = "B2K", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型中置轴旅居挂车", Val = "B2U", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型中置轴车辆运输车", Val = "B2V", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型中置轴普通挂车", Val = "B2W", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型普通半挂车", Val = "B31", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型厢式半挂车", Val = "B32", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型罐式半挂车", Val = "B33", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型平板半挂车", Val = "B34", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型自卸半挂车", Val = "B35", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型仓栅式半挂车", Val = "B36", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型旅居半挂车", Val = "B37", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型专项作业半挂车", Val = "B38", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型低平板半挂车", Val = "B39", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型车辆运输半挂车", Val = "B3C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型罐式自卸半挂车", Val = "B3D", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型平板自卸半挂车", Val = "B3E", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型集装箱自卸半挂车", Val = "B3F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型特殊结构自卸半挂车", Val = "B3G", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型仓栅式自卸半挂车", Val = "B3H", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型专项作业自卸半挂车", Val = "B3J", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型低平板自卸半挂车", Val = "B3K", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型中置轴旅居挂车", Val = "B3U", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型中置轴车辆运输车", Val = "B3V", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型中置轴普通挂车", Val = "B3W", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "无轨电车", Val = "D11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "有轨电车", Val = "D12", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型普通全挂车", Val = "G11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型厢式全挂车", Val = "G12", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型罐式全挂车", Val = "G13", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型平板全挂车", Val = "G14", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型集装箱全挂车", Val = "G15", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型自卸全挂车", Val = "G16", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型仓栅式全挂车", Val = "G17", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型旅居全挂车", Val = "G18", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型专项作业全挂车", Val = "G19", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型厢式自卸全挂车", Val = "G1A", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型罐式自卸全挂车", Val = "G1B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型平板自卸全挂车", Val = "G1C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型集装箱自卸全挂车", Val = "G1D", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型仓栅式自卸全挂车", Val = "G1E", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型专项作业自卸全挂车", Val = "G1F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型普通全挂车", Val = "G21", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型厢式全挂车", Val = "G22", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型罐式全挂车", Val = "G23", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型平板全挂车", Val = "G24", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型集装箱全挂车", Val = "G25", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型自卸全挂车", Val = "G26", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型仓栅式全挂车", Val = "G27", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型旅居全挂车", Val = "G28", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型专项作业全挂车", Val = "G29", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型厢式自卸全挂车", Val = "G2A", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型罐式自卸全挂车", Val = "G2B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型平板自卸全挂车", Val = "G2C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型集装箱自卸全挂车", Val = "G2D", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型仓栅式自卸全挂车", Val = "G2E", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型专项作业自卸全挂车", Val = "G2F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型普通全挂车", Val = "G31", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型厢式全挂车", Val = "G32", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型罐式全挂车", Val = "G33", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型平板全挂车", Val = "G34", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型自卸全挂车", Val = "G35", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型仓栅式全挂车", Val = "G36", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型旅居全挂车", Val = "G37", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型专项作业全挂车", Val = "G38", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型厢式自卸全挂车", Val = "G3A", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型罐式自卸全挂车", Val = "G3B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型平板自卸全挂车", Val = "G3C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型集装箱自卸全挂车", Val = "G3D", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型仓栅式自卸全挂车", Val = "G3E", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型专项作业自卸全挂车", Val = "G3F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型普通货车", Val = "H11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型厢式货车", Val = "H12", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型封闭货车", Val = "H13", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型罐式货车", Val = "H14", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型平板货车", Val = "H15", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型集装厢车", Val = "H16", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型自卸货车", Val = "H17", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型特殊结构货车", Val = "H18", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型仓栅式货车", Val = "H19", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型车辆运输车", Val = "H1A", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型厢式自卸货车", Val = "H1B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型罐式自卸货车", Val = "H1C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型平板自卸货车", Val = "H1D", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型集装厢自卸货车", Val = "H1E", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型特殊结构自卸货车", Val = "H1F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型仓栅式自卸货车", Val = "H1G", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型普通货车", Val = "H21", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型厢式货车", Val = "H22", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型封闭货车", Val = "H23", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型罐式货车", Val = "H24", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型平板货车", Val = "H25", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型集装厢车", Val = "H26", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型自卸货车", Val = "H27", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型特殊结构货车", Val = "H28", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型仓栅式货车", Val = "H29", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型车辆运输车", Val = "H2A", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型厢式自卸货车", Val = "H2B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型罐式自卸货车", Val = "H2C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型平板自卸货车", Val = "H2D", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型集装厢自卸货车", Val = "H2E", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型特殊结构自卸货车", Val = "H2F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型仓栅式自卸货车", Val = "H2G", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型普通货车", Val = "H31", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型厢式货车", Val = "H32", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型封闭货车", Val = "H33", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型罐式货车", Val = "H34", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型平板货车", Val = "H35", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型自卸货车", Val = "H37", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型特殊结构货车", Val = "H38", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型仓栅式货车", Val = "H39", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型车辆运输车", Val = "H3A", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型厢式自卸货车", Val = "H3B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型罐式自卸货车", Val = "H3C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型平板自卸货车", Val = "H3D", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型特殊结构自卸货车", Val = "H3F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型仓栅式自卸货车", Val = "H3G", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型普通货车", Val = "H41", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型厢式货车", Val = "H42", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型封闭货车", Val = "H43", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型罐式货车", Val = "H44", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型自卸货车", Val = "H45", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型特殊结构货车", Val = "H46", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型仓栅式货车", Val = "H47", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型车辆运输车", Val = "H4A", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型厢式自卸货车", Val = "H4B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型罐式自卸货车", Val = "H4C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型特殊结构自卸货车", Val = "H4F", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型仓栅式自卸货车", Val = "H4G", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "普通低速货车", Val = "H51", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "厢式低速货车", Val = "H52", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "罐式低速货车", Val = "H53", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "自卸低速货车", Val = "H54", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "仓栅式低速货车", Val = "H55", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "厢式自卸低速货车", Val = "H5B", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "罐式自卸低速货车", Val = "H5C", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轮式装载机械", Val = "J11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轮式挖掘机械", Val = "J12", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轮式平地机械", Val = "J13", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型普通客车", Val = "K11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型双层客车", Val = "K12", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型卧铺客车", Val = "K13", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型铰接客车", Val = "K14", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型越野客车", Val = "K15", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型轿车", Val = "K16", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型专用客车", Val = "K17", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型专用校车", Val = "K18", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型普通客车", Val = "K21", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型双层客车", Val = "K22", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型卧铺客车", Val = "K23", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型铰接客车", Val = "K24", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型越野客车", Val = "K25", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型轿车", Val = "K26", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型专用客车", Val = "K27", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型专用校车", Val = "K28", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型普通客车", Val = "K31", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型越野客车", Val = "K32", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型轿车", Val = "K33", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型专用客车", Val = "K34", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型专用校车", Val = "K38", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型面包车", Val = "K39", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型半挂牵引车", Val = "Q31", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型半挂牵引车", Val = "Q11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型全挂牵引车", Val = "Q12", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型半挂牵引车", Val = "Q21", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型全挂牵引车", Val = "Q22", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型全挂牵引车", Val = "Q32", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "普通正三轮摩托车", Val = "M11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻便正三轮摩托车", Val = "M12", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "正三轮载客摩托车", Val = "M13", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "正三轮载货摩托车", Val = "M14", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "侧三轮摩托车", Val = "M15", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "普通二轮摩托车", Val = "M21", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻便二轮摩托车", Val = "M22", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型轮式拖拉机", Val = "T11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型轮式拖拉机", Val = "T21", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "手扶拖拉机", Val = "T22", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "手扶变形运输机", Val = "T23", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型拖拉机", Val = "T20", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "多功能拖拉机", Val = "T19", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型专项作业车", Val = "Z71", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型专项作业车", Val = "Z41", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型专项作业车", Val = "Z31", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型专项作业车", Val = "Z21", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型专项作业车", Val = "Z11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型专项作业车", Val = "Z51", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型普通客车", Val = "K41", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型越野客车", Val = "K42", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型轿车", Val = "K43", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型面包车", Val = "K49", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "三轮汽车", Val = "N11", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "大型载货专项作业车", Val = "Z12", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "中型载货专项作业车", Val = "Z22", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "小型载货专项作业车", Val = "Z32", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "微型载货专项作业车", Val = "Z42", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "重型载货专项作业车", Val = "Z52", DefineType = "CLZL" });
            DefineTpye.Add(new KVEntity() { Key = "轻型载货专项作业车", Val = "Z72", DefineType = "CLZL" });
        }

        private void InitConfig()
        {
            try
            {
                if (!File.Exists(SettingPath))
                {
                    throw new Exception("初始化数据失败：路径" + SettingPath + "不存在！");
                }
                string configStr = File.ReadAllText(SettingPath);
                AppSetting = JsonConvert.DeserializeObject<SettingEntity>(configStr);

                if (!File.Exists(PrintConfigPath))
                {
                    throw new Exception("初始化数据失败：路径" + PrintConfigPath + "不存在！");
                }
                configStr = File.ReadAllText(PrintConfigPath);
                PointSetting = JsonConvert.DeserializeObject<PrintPoint>(configStr);
            }
            catch
            {
                throw;
            }
        }

        public static string GetNameByCode(string code, string type)
        {
            KVEntity entity = DefineTpye.Where(p => p.DefineType.Equals(type) && p.Val.Equals(code)).FirstOrDefault();
            if (entity != null)
            {
                return entity.Key;
            }
            return code;
        }

        public static string GetCodeByName(string name, string type)
        {
            KVEntity entity = DefineTpye.Where(p => p.DefineType.Equals(type) && p.Key.Equals(name)).FirstOrDefault();
            if (entity != null)
            {
                return entity.Val;
            }
            return name;
        }
    }
}
