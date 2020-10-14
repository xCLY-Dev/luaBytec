using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ScintillaNET;
using luaBytec;

namespace ExampleUse
{
    public partial class Form1 : Form
    {
        public luaBytec.Library lib = new luaBytec.Library();
        public Form1()
        {
            InitializeComponent();
        }

        private string RobloxGlobals()
        {
            string[] array = new string[]
            {
                "writefile",
                "Writefile",
                "readfile",
                "Readfile",
                "getrawmetatable",
                "setrawmetatable",
                "GetObjects",
                "getObjects",
                "HttpGet",
                "wait",
                "Wait",
                "getclipboard",
                "setclipboard",
                "game",
                "Game",
                "workspace",
                "Workspace",
                "script",
                "LoadLibrary",
                "delay",
                "Delay",
                "Enum",
                "Axes",
                "BrickColor",
                "CFrame",
                "Color3",
                "ColorSequence",
                "ColorSequenceKeypoint",
                "Faces",
                "Instance",
                "NumberRange",
                "NumberSequence",
                "NumberSequenceKeypoint",
                "PhysicalProperties",
                "Random",
                "Ray",
                "Rect",
                "Region3",
                "Region3int16",
                "TweenInfo",
                "UDim",
                "UDim2",
                "Vector2",
                "Vector3",
                "Vector3int16",
                "warn",
                "printidentity",
                "elapsedTime",
                "spawn",
                "Spawn",
                "tick",
                "time",
                "ypcall",
                "select",
                "newproxy",
                "DockWidgetPluginGuiInfo",
                "PathWaypoint",
                "UserSettings",
                "version"
            };
            string str = "";
            for (int i = 0; i < array.Length - 1; i++)
            {
                str = str + array[i] + " ";
            }
            return str + array[array.Length - 1];
        }

		private int maxLineNumberCharLength;
		private void Form1_Load(object sender, EventArgs e)
        {
			int length = this.scintilla1.Lines.Count.ToString().Length;
			if (length != this.maxLineNumberCharLength)
			{
				this.scintilla1.Margins[0].Width = this.scintilla1.TextWidth(33, new string('9', length + 1)) + 2;
				this.maxLineNumberCharLength = length;
			}
			string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			string str2 = "0123456789";
			string str3 = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";
			this.scintilla1.StyleResetDefault();
			this.scintilla1.Styles[32].Font = "Consolas";
			this.scintilla1.Styles[32].Size = 10;
			this.scintilla1.StyleClearAll();
			this.scintilla1.Styles[0].ForeColor = Color.Silver;
			this.scintilla1.Styles[1].ForeColor = Color.Green;
			this.scintilla1.Styles[2].ForeColor = Color.Green;
			this.scintilla1.Styles[4].ForeColor = Color.Olive;
			this.scintilla1.Styles[5].ForeColor = Color.Blue;
			this.scintilla1.Styles[13].ForeColor = Color.BlueViolet;
			this.scintilla1.Styles[14].ForeColor = Color.DarkSlateBlue;
			this.scintilla1.Styles[15].ForeColor = Color.DarkSlateBlue;
			this.scintilla1.Styles[6].ForeColor = Color.Red;
			this.scintilla1.Styles[7].ForeColor = Color.Red;
			this.scintilla1.Styles[8].ForeColor = Color.Red;
			this.scintilla1.Styles[12].BackColor = Color.Pink;
			this.scintilla1.Styles[10].ForeColor = Color.Purple;
			this.scintilla1.Styles[9].ForeColor = Color.Maroon;
			this.scintilla1.Lexer = (Lexer)15;
			this.scintilla1.WordChars = str + str2 + str3;
			this.scintilla1.SetKeywords(0, "and break do else elseif end for function if in local nil not or repeat return then until while false true goto");
			this.scintilla1.SetKeywords(1, this.RobloxGlobals() + "assert collectgarbage dofile error _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug getfenv gcinfo loadstring loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV ");
			this.scintilla1.SetKeywords(2, "string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offset");
			this.scintilla1.SetKeywords(3, "coroutine.create coroutine.resume coroutine.status coroutine.wrap coroutine.yield io.close io.flush io.input io.lines io.open io.output io.read io.tmpfile io.type io.write io.stdin io.stdout io.stderr os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname coroutine.isyieldable coroutine.running io.popen module package.loaders package.seeall package.config package.searchers package.searchpath require package.cpath package.loaded package.loadlib package.path package.preload");
			this.scintilla1.SetProperty("fold", "1");
			this.scintilla1.SetProperty("fold.compact", "1");
			this.scintilla1.Margins[2].Type = 0;
			this.scintilla1.Margins[2].Mask = 4261412864U;
			this.scintilla1.Margins[2].Sensitive = true;
			this.scintilla1.Margins[2].Width = 20;
			for (int i = 25; i <= 31; i++)
			{
				this.scintilla1.Markers[i].SetForeColor(SystemColors.ControlLightLight);
				this.scintilla1.Markers[i].SetBackColor(SystemColors.ControlDark);
			}
			this.scintilla1.Markers[30].Symbol = (MarkerSymbol)12;
			this.scintilla1.Markers[31].Symbol = (MarkerSymbol)14;
			this.scintilla1.Markers[25].Symbol = (MarkerSymbol)13;
			this.scintilla1.Markers[27].Symbol = (MarkerSymbol)11;
			this.scintilla1.Markers[26].Symbol = (MarkerSymbol)15;
			this.scintilla1.Markers[29].Symbol = (MarkerSymbol)9;
			this.scintilla1.Markers[28].Symbol = (MarkerSymbol)10;
			this.scintilla1.AutomaticFold = (AutomaticFold)7;
		}

        private void scintilla1_Click(object sender, EventArgs e)
        {

        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            int length = this.scintilla1.Lines.Count.ToString().Length;
            if (length != this.maxLineNumberCharLength)
            {
                this.scintilla1.Margins[0].Width = this.scintilla1.TextWidth(33, new string('9', length + 1)) + 2;
                this.maxLineNumberCharLength = length;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scintilla1.ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scintilla1.Text = lib.EncryptForRoblox(scintilla1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scintilla1.Text = lib.EncryptByteCode(scintilla1.Text);
        }
    }
}
