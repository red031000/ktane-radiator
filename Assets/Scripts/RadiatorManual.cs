﻿using System.IO;

namespace Assets.Scripts.RuleGenerator
{
	public class RadiatorManual
	{
		public string Manual = "<!DOCTYPE html>" +
			"<html>" +
			"<head>" +
			"    <meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\">" +
			"    <meta content=\"IE=edge\" http-equiv=\"X-UA-Compatible\">" +
			"    <title>Radiator — Keep Talking and Nobody Explodes Module</title>" +
			"    <meta content=\"initial-scale=1\" name=\"viewport\">" +
			"    <link rel='stylesheet' type='text/css' href='css/font.css'>" +
			"    <link href=\"css/normalize.css\" rel=\"stylesheet\" type=\"text/css\">" +
			"    <link href=\"css/main.css\" rel=\"stylesheet\" type=\"text/css\">" +
			"    <script src='js/highlighter.js'></script>" +
			"    <style>" +
			"        table {" +
			"            margin-top: 1em;" +
			"        }" +
			"    </style>" +
			"</head>" +
			"<body>" +
			"    <div class=\"section\">" +
			"        <div class=\"page page-bg-01\">" +
			"            <div class=\"page-header\">" +
			"                <span class=\"page-header-doc-title\">Keep Talking and Nobody Explodes Mod - Seed #RULEGENERATORSEED</span>" +
			"                <span class=\"page-header-section-title\">Radiator</span>" +
			"            </div>" +
			"            <div class=\"page-content\">" +
			"                <img src=\"img/Component/Radiator.svg\" class=\"diagram\">" +
			"                <h2>On the Subject of Radiator</h2>" +
			"                <p class=\"flavour-text\">" +
			"                    Is it me or is it getting hot in here?" +
			"                </p>" +
			"" +
			"               <p>This module has 2 stages. The temperature stage and the water stage. You will need to keep the value of the temperature stage to work out the value of the water stage.</p>" +
			"                <p>Submit the temperature stage before the water stage. If you make a mistake, press the reset button.</p>" +
			"                <p>If the number is not correct for that stage, a strike will be given, and the module must be started over.</p>" +
			"                <p><strong>HOWEVER</strong>, if a UNICORNINDICATOR1STATE UNICORNINDICATOR1 indicator and a UNICORNINDICATOR2STATE UNICORNINDICATOR2 indicator are present, submit UNICORNTEMPVALUE for the temperature and UNICORNWATERVALUE for the water.</p>" + //TODO: add the option of ports/batteries in the future
			"                <p>If a number is greater than 99, only use the last two digits of the number.</p>" +
			"" +
			"                <table>" +
			"                    <tbody>" +
			"                        <tr>" +
			"                            <td>" +
			"                                <strong><em>Temperature</em></strong><br>" +
			"                                Starting at 0, if the serial number contains one or more of the letters and numbers: SERIALNUMBERLETTERS, add TEMPSERIALAMOUNT for every occurrence of each letter or number.<br>" +
			"                                For every ADDTONUMBEROBJECT, add ADDTONUMBERAMOUNT to the number.<br>" +
			"                                For every TAKEFROMNUMBEROBJECT, take TAKEFROMNUMBERAMOUNT away from the number.<br>" +
			"                                If you end up with a negative number after you have applied these rules then multiply by -1.<br>" +
			"                                Submit the number and keep the answer for the water stage.<br>" +
			"                            </td>" +
			"                        </tr>" +
			"                        <tr>" +
			"                            <td>" +
			"                                <strong><em>Water</em></strong><br>" +
			"                                Take the number you got for the temperature and WATERINITIALOPERATION WATERINITIALAMOUNT.<br>" +
			"                                If the number is not a whole number, only take the integer part of the number.<br>" +
			"                                If there WATERADDTONUMBERLARGEOBJECT, add WATERADDTONUMBERLAMOUNT to the number.<br>" +
			"                                If there WATERADDTONUMBERSMALLOBJECT, add WATERADDTONUMBERSAMOUNT to the number.<br>" +
			"                                If there TABLEOBJECTWPREFIX, follow the table for TABLEOBJECT below.<br>" +
			"                                At the end if you receive a negative number multiply by -1.<br>" +
			"                                Submit this number.<br>" +
			"                            </td>" +
			"                        </tr>" +
			"                    </tbody>" +
			"                </table>" +
			"" +
			"                <table>" +
			"                    <tbody>" +
			"                        <tr>" +
			"                            <td>" +
			"                                <strong><em>TABLEOBJECT table</em></strong><br>" +
			"                                TABLEOBJECT1 --> TABLEOBJECT1VALUE<br>" +
			"                                TABLEOBJECT2 --> TABLEOBJECT2VALUE<br>" +
			"                                TABLEOBJECT3 --> TABLEOBJECT3VALUE<br>" +
			"                                TABLEOBJECT4 --> TABLEOBJECT4VALUE<br>" +
			"                                TABLEOBJECT5 --> TABLEOBJECT5VALUE<br>" +
			"                            </td>" +
			"                        </tr>" +
			"                    </tbody>" +
			"                </table>" +
			"            </div>" +
			"            <div class=\"page-footer relative-footer\">Page 1 of 1</div>" +
			"        </div>" +
			"    </div>" +
			"</body>" +
			"</html>";

		public static string[] ImagePaths =
		{
			Path.Combine("img", "Component")
		};
		public static string[] TextAssetPaths =
		{
			Path.Combine(ImagePaths[0],"Radiator.svg")
		};
		public static string[] TextAssets =
		{
			"<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 348 348\" fill=\"none\" stroke-linecap=\"square\" stroke-miterlimit=\"10\"><clipPath id=\"a\"><path d=\"M0 0h348v348H0V0z\"/></clipPath><g clip-path=\"url(#a)\"><path fill=\"none\" d=\"M0 0h348v348H0z\"/><path fill=\"#fff\" d=\"M-6 0h348v348H-6z\"/><path fill=\"none\" d=\"M5 5.8h337v337.6H5z\"/><path stroke=\"#000\" stroke-width=\"2\" stroke-linejoin=\"round\" stroke-linecap=\"butt\" d=\"M5 5.8h337v337.6H5z\"/><path fill=\"#fff\" d=\"M282.7 40.6c0-8.4 7-15.2 15.6-15.2 4.1 0 8 1.6 11 4.4a15 15 0 0 1 4.6 10.8c0 8.3-7 15.1-15.6 15.1s-15.6-6.8-15.6-15.1z\"/><path stroke=\"#000\" stroke-width=\"2\" stroke-linejoin=\"round\" stroke-linecap=\"butt\" d=\"M282.7 40.6c0-8.4 7-15.2 15.6-15.2 4.1 0 8 1.6 11 4.4a15 15 0 0 1 4.6 10.8c0 8.3-7 15.1-15.6 15.1s-15.6-6.8-15.6-15.1z\"/></g><path fill=\"#fff\" stroke=\"#000\" d=\"M35.4 274.3h277.2v53.1H35.4z\"/><path fill=\"#fff\" stroke=\"#000\" stroke-width=\"1.3\" d=\"M18.7 255.5h310.6v79.7H18.7z\"/><path fill=\"#fff\" stroke=\"#000\" d=\"M25.8 34.7h45.7v45.7H25.8zM89.2 33.2h45.7v45.7H89.2zM149.7 33.2h45.7v45.7h-45.7zM214.9 32.4h45.7v45.7h-45.7zM27.3 100.7H73v45.7H27.3zM28.8 179.2h45.7v45.7H28.8zM91.6 101.8h45.7v45.7H91.6zM90.7 179.2h45.7v45.7H90.7zM155.6 102.2h45.7v45.7h-45.7zM155.6 177.7h45.7v45.7h-45.7z\"/><path fill=\"#fff\" stroke=\"#000\" stroke-width=\"1.5\" d=\"M213.3 103.7h103.4v45.7H213.3zM216.7 179.2h103.4v45.7H216.7z\"/><flowRoot xml:space=\"preserve\" style=\"line-height:125%\" transform=\"translate(310.8 238)\" font-size=\"40\" font-style=\"normal\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" fill-opacity=\"1\" stroke=\"none\" font-family=\"Sans\"><flowRegion><path d=\"M-209-55h30.6v38.9H-209z\"/></flowRegion><flowPara/></flowRoot><flowRoot xml:space=\"preserve\" style=\"line-height:125%\" transform=\"matrix(.77877 0 0 .80632 312 103.6)\" font-size=\"40\" font-style=\"normal\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" fill-opacity=\"1\" stroke=\"none\" font-family=\"Sans\"><flowRegion><path d=\"M-118.9 102.4H8v38.9h-126.9z\"/></flowRegion><flowPara/></flowRoot><flowRoot xml:space=\"preserve\" style=\"line-height:125%\" transform=\"translate(247.3 236.4)\" font-size=\"40\" font-style=\"normal\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" fill-opacity=\"1\" stroke=\"none\" font-family=\"Sans\"><flowRegion><path d=\"M-209-55h26.4v38.9H-209z\"/></flowRegion><flowPara/></flowRoot><text style=\"line-height:125%\" x=\"50\" y=\"153\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"/><text style=\"line-height:125%\" x=\"110\" y=\"141.5\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"/><text style=\"line-height:125%\" x=\"176.7\" y=\"142.1\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"/><text style=\"line-height:125%\" x=\"37.5\" y=\"137.4\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"37.5\" y=\"137.4\">3</tspan></text><text style=\"line-height:125%\" x=\"101.1\" y=\"141\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"101.1\" y=\"141\">4</tspan></text><text style=\"line-height:125%\" x=\"163.7\" y=\"139.5\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"163.7\" y=\"139.5\">5</tspan></text><text style=\"line-height:125%\" x=\"37\" y=\"69.1\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"37\" y=\"69.1\">6</tspan></text><text style=\"line-height:125%\" x=\"100.1\" y=\"68.6\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"100.1\" y=\"68.6\">7</tspan></text><text style=\"line-height:125%\" x=\"161.1\" y=\"67.5\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"161.1\" y=\"67.5\">8</tspan></text><text style=\"line-height:125%\" x=\"226.3\" y=\"68.6\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"226.3\" y=\"68.6\">9</tspan></text><text style=\"line-height:125%\" x=\"168.9\" y=\"213.5\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"168.9\" y=\"213.5\">2</tspan></text><text style=\"line-height:125%\" x=\"103.2\" y=\"215.6\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"103.2\" y=\"215.6\">1</tspan></text><text style=\"line-height:125%\" x=\"39.6\" y=\"214.5\" font-size=\"40\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"39.6\" y=\"214.5\">0</tspan></text><text style=\"line-height:125%\" x=\"233.8\" y=\"131.2\" transform=\"scale(.92007 1.08687)\" font-size=\"39.4\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"233.8\" y=\"131.2\">Reset</tspan></text><text style=\"line-height:125%\" x=\"278.4\" y=\"174\" transform=\"scale(.79576 1.25666)\" font-size=\"37.4\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"278.4\" y=\"174\">Submit</tspan></text><text style=\"line-height:125%\" x=\"28.7\" y=\"262.2\" transform=\"scale(.80541 1.2416)\" font-size=\"68.5\" font-weight=\"400\" letter-spacing=\"0\" word-spacing=\"0\" fill=\"#000\" font-family=\"Sans\"><tspan x=\"28.7\" y=\"262.2\">&lt;DISPLAY&gt;</tspan></text></svg>"
		};
	}
}