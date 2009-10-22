// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2008
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.5.190
// Machine:  ATTIC-1
// DateTime: 9/03/2009 10:44:16 AM
// UserName: john
// Input file <gppg.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using System.Collections;

namespace QUT.GPGen.Parser
{
internal enum Token {error=126,
    EOF=127,codeStart=128,codeEnd=129,ident=130,anchoredSymbol=131,number=132,
    filePath=133,litstring=134,verbatim=135,litchar=136,kwPCPC=137,kwLbrace=138,
    kwRbrace=139,kwToken=140,kwType=141,kwLeft=142,kwRight=143,kwNonassoc=144,
    kwPrec=145,kwStart=146,kwUnion=147,kwDefines=148,kwLocations=149,kwNamespace=150,
    kwPartial=151,kwOutput=152,kwParsertype=153,kwTokentype=154,kwScanbasetype=155,kwUsing=156,
    kwVisibility=157,kwYYSTYPE=158,kwYYLTYPE=159,maxParseToken=160,errTok=161};

internal partial struct ValueType
{ public int iVal; 
         public List<string> stringList;
         public List<TokenInfo> tokenList;
         public TokenInfo tokenInfo; 
         public Production prod;
         public ActionProxy proxy;
       }
// Abstract base class for GPLEX scanners
internal abstract class ScanBase : AbstractScanner<ValueType,LexSpan> {
  private LexSpan __yylloc = new LexSpan();
  public override LexSpan yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

internal partial class Parser: ShiftReduceParser<ValueType, LexSpan>
{
/*
 *  Parser spec for GPPG
 *  gppg.y: Author: John Gough, August 2008
 *  Process with > GPPG /gplex /no-lines gppg.y
 */
#pragma warning disable 649
    private Dictionary<int, string> aliasses;
#pragma warning restore 649

  protected override void Initialize()
  {
    this.InitSpecialTokens((int)Token.error, (int)Token.EOF);

    this.InitStateTable(151);
    AddState(0,new State(new int[]{138,45,140,49,141,78,142,87,143,90,144,93,146,96,147,98,149,122,148,123,151,124,150,125,156,127,152,131,155,136,153,138,157,140,154,142,158,144,159,146,126,149,137,-10},new int[]{-10,1,-12,3,-17,43,-18,148,-19,48}));
    AddState(1,new State(new int[]{127,2}));
    AddState(2,new State(-1));
    AddState(3,new State(new int[]{137,42},new int[]{-13,4}));
    AddState(4,new State(new int[]{131,38,126,41},new int[]{-14,5,-33,40,-34,12}));
    AddState(5,new State(new int[]{137,8,131,38,127,-6},new int[]{-15,6,-33,7,-34,12}));
    AddState(6,new State(-2));
    AddState(7,new State(-83));
    AddState(8,new State(new int[]{128,10,127,-8},new int[]{-16,9}));
    AddState(9,new State(-5));
    AddState(10,new State(new int[]{129,11}));
    AddState(11,new State(-7));
    AddState(12,new State(new int[]{130,23,136,24,134,25,123,28,145,32,59,-90,124,-90},new int[]{-6,13,-7,18,-4,35,-36,26,-9,36,-8,27}));
    AddState(13,new State(-88,new int[]{-35,14}));
    AddState(14,new State(new int[]{59,15,124,16}));
    AddState(15,new State(-86));
    AddState(16,new State(new int[]{130,23,136,24,134,25,123,28,145,32,59,-90,124,-90},new int[]{-6,17,-7,18,-4,35,-36,26,-9,36,-8,27}));
    AddState(17,new State(-89));
    AddState(18,new State(new int[]{123,28,145,32,59,-91,124,-91},new int[]{-9,19,-8,27}));
    AddState(19,new State(new int[]{130,23,136,24,134,25,123,-95,145,-95,59,-95,124,-95},new int[]{-5,20,-4,21,-36,26}));
    AddState(20,new State(-94));
    AddState(21,new State(new int[]{130,23,136,24,134,25,123,-96,145,-96,59,-96,124,-96},new int[]{-36,22}));
    AddState(22,new State(-98));
    AddState(23,new State(-99));
    AddState(24,new State(-100));
    AddState(25,new State(-101));
    AddState(26,new State(-97));
    AddState(27,new State(-102));
    AddState(28,new State(new int[]{128,10,125,-8,126,-8},new int[]{-16,29}));
    AddState(29,new State(new int[]{125,30,126,31}));
    AddState(30,new State(-105));
    AddState(31,new State(-106));
    AddState(32,new State(new int[]{130,33}));
    AddState(33,new State(new int[]{123,28,130,-104,136,-104,134,-104,145,-104,59,-104,124,-104},new int[]{-8,34}));
    AddState(34,new State(-103));
    AddState(35,new State(new int[]{130,23,136,24,134,25,123,-92,145,-92,59,-92,124,-92},new int[]{-36,22}));
    AddState(36,new State(new int[]{130,23,136,24,134,25,123,-95,145,-95,59,-95,124,-95},new int[]{-5,37,-4,21,-36,26}));
    AddState(37,new State(-93));
    AddState(38,new State(new int[]{58,39}));
    AddState(39,new State(-87));
    AddState(40,new State(-84));
    AddState(41,new State(-85));
    AddState(42,new State(-4));
    AddState(43,new State(new int[]{138,45,140,49,141,78,142,87,143,90,144,93,146,96,147,98,149,122,148,123,151,124,150,125,156,127,152,131,155,136,153,138,157,140,154,142,158,144,159,146,137,-9},new int[]{-18,44,-19,48}));
    AddState(44,new State(-12));
    AddState(45,new State(new int[]{128,10,139,-8},new int[]{-16,46}));
    AddState(46,new State(new int[]{139,47}));
    AddState(47,new State(-15));
    AddState(48,new State(-16));
    AddState(49,new State(new int[]{60,73,130,-43,136,-43},new int[]{-20,50,-21,72}));
    AddState(50,new State(new int[]{130,54,136,58},new int[]{-1,51,-2,71}));
    AddState(51,new State(new int[]{44,60,59,61,58,62,60,63,62,64,40,65,41,66,91,67,93,68,123,69,125,70,138,-17,140,-17,141,-17,142,-17,143,-17,144,-17,146,-17,147,-17,149,-17,148,-17,151,-17,150,-17,156,-17,152,-17,155,-17,153,-17,157,-17,154,-17,158,-17,159,-17,137,-17,130,-70,136,-70},new int[]{-28,52,-29,59}));
    AddState(52,new State(new int[]{130,54,136,58},new int[]{-2,53}));
    AddState(53,new State(-47));
    AddState(54,new State(new int[]{132,55,134,56,44,-51,59,-51,58,-51,60,-51,62,-51,40,-51,41,-51,91,-51,93,-51,123,-51,125,-51,130,-51,136,-51,138,-51,140,-51,141,-51,142,-51,143,-51,144,-51,146,-51,147,-51,149,-51,148,-51,151,-51,150,-51,156,-51,152,-51,155,-51,153,-51,157,-51,154,-51,158,-51,159,-51,137,-51}));
    AddState(55,new State(-49));
    AddState(56,new State(new int[]{132,57,44,-52,59,-52,58,-52,60,-52,62,-52,40,-52,41,-52,91,-52,93,-52,123,-52,125,-52,130,-52,136,-52,138,-52,140,-52,141,-52,142,-52,143,-52,144,-52,146,-52,147,-52,149,-52,148,-52,151,-52,150,-52,156,-52,152,-52,155,-52,153,-52,157,-52,154,-52,158,-52,159,-52,137,-52}));
    AddState(57,new State(-50));
    AddState(58,new State(-53));
    AddState(59,new State(-48));
    AddState(60,new State(-69));
    AddState(61,new State(-73));
    AddState(62,new State(-74));
    AddState(63,new State(-75));
    AddState(64,new State(-76));
    AddState(65,new State(-77));
    AddState(66,new State(-78));
    AddState(67,new State(-79));
    AddState(68,new State(-80));
    AddState(69,new State(-81));
    AddState(70,new State(-82));
    AddState(71,new State(-46));
    AddState(72,new State(-42));
    AddState(73,new State(new int[]{130,74,126,76}));
    AddState(74,new State(new int[]{62,75}));
    AddState(75,new State(-44));
    AddState(76,new State(new int[]{62,77}));
    AddState(77,new State(-45));
    AddState(78,new State(new int[]{60,73},new int[]{-21,79}));
    AddState(79,new State(new int[]{130,83,131,84},new int[]{-3,80,-22,86}));
    AddState(80,new State(new int[]{44,60,59,61,58,62,60,63,62,64,40,65,41,66,91,67,93,68,123,69,125,70,138,-18,140,-18,141,-18,142,-18,143,-18,144,-18,146,-18,147,-18,149,-18,148,-18,151,-18,150,-18,156,-18,152,-18,155,-18,153,-18,157,-18,154,-18,158,-18,159,-18,137,-18,130,-70,131,-70},new int[]{-28,81,-29,85}));
    AddState(81,new State(new int[]{130,83,131,84},new int[]{-22,82}));
    AddState(82,new State(-55));
    AddState(83,new State(-57));
    AddState(84,new State(-58));
    AddState(85,new State(-56));
    AddState(86,new State(-54));
    AddState(87,new State(new int[]{60,73,130,-43,136,-43},new int[]{-20,88,-21,72}));
    AddState(88,new State(new int[]{130,54,136,58},new int[]{-1,89,-2,71}));
    AddState(89,new State(new int[]{44,60,59,61,58,62,60,63,62,64,40,65,41,66,91,67,93,68,123,69,125,70,138,-19,140,-19,141,-19,142,-19,143,-19,144,-19,146,-19,147,-19,149,-19,148,-19,151,-19,150,-19,156,-19,152,-19,155,-19,153,-19,157,-19,154,-19,158,-19,159,-19,137,-19,130,-70,136,-70},new int[]{-28,52,-29,59}));
    AddState(90,new State(new int[]{60,73,130,-43,136,-43},new int[]{-20,91,-21,72}));
    AddState(91,new State(new int[]{130,54,136,58},new int[]{-1,92,-2,71}));
    AddState(92,new State(new int[]{44,60,59,61,58,62,60,63,62,64,40,65,41,66,91,67,93,68,123,69,125,70,138,-20,140,-20,141,-20,142,-20,143,-20,144,-20,146,-20,147,-20,149,-20,148,-20,151,-20,150,-20,156,-20,152,-20,155,-20,153,-20,157,-20,154,-20,158,-20,159,-20,137,-20,130,-70,136,-70},new int[]{-28,52,-29,59}));
    AddState(93,new State(new int[]{60,73,130,-43,136,-43},new int[]{-20,94,-21,72}));
    AddState(94,new State(new int[]{130,54,136,58},new int[]{-1,95,-2,71}));
    AddState(95,new State(new int[]{44,60,59,61,58,62,60,63,62,64,40,65,41,66,91,67,93,68,123,69,125,70,138,-21,140,-21,141,-21,142,-21,143,-21,144,-21,146,-21,147,-21,149,-21,148,-21,151,-21,150,-21,156,-21,152,-21,155,-21,153,-21,157,-21,154,-21,158,-21,159,-21,137,-21,130,-70,136,-70},new int[]{-28,52,-29,59}));
    AddState(96,new State(new int[]{130,83,131,84},new int[]{-22,97}));
    AddState(97,new State(-22));
    AddState(98,new State(new int[]{130,121,123,-39},new int[]{-23,99}));
    AddState(99,new State(new int[]{123,101},new int[]{-24,100}));
    AddState(100,new State(-23));
    AddState(101,new State(new int[]{130,117,126,120},new int[]{-30,102,-31,119,-32,105,-27,118,-25,109}));
    AddState(102,new State(new int[]{125,103,130,117},new int[]{-31,104,-32,105,-27,118,-25,109}));
    AddState(103,new State(-62));
    AddState(104,new State(-64));
    AddState(105,new State(new int[]{130,106},new int[]{-27,108,-25,109}));
    AddState(106,new State(new int[]{59,107,91,-41,46,-41,60,-41,130,-41}));
    AddState(107,new State(-66));
    AddState(108,new State(-68));
    AddState(109,new State(new int[]{91,110,46,112,60,114,130,-61,62,-61,138,-61,140,-61,141,-61,142,-61,143,-61,144,-61,146,-61,147,-61,149,-61,148,-61,151,-61,150,-61,156,-61,152,-61,155,-61,153,-61,157,-61,154,-61,158,-61,159,-61,137,-61}));
    AddState(110,new State(new int[]{93,111}));
    AddState(111,new State(-59));
    AddState(112,new State(new int[]{130,113}));
    AddState(113,new State(-40));
    AddState(114,new State(new int[]{130,117},new int[]{-27,115,-25,109}));
    AddState(115,new State(new int[]{62,116}));
    AddState(116,new State(-60));
    AddState(117,new State(-41));
    AddState(118,new State(-67));
    AddState(119,new State(-63));
    AddState(120,new State(-65));
    AddState(121,new State(-38));
    AddState(122,new State(-24));
    AddState(123,new State(-25));
    AddState(124,new State(-26));
    AddState(125,new State(new int[]{130,117},new int[]{-25,126}));
    AddState(126,new State(new int[]{46,112,138,-27,140,-27,141,-27,142,-27,143,-27,144,-27,146,-27,147,-27,149,-27,148,-27,151,-27,150,-27,156,-27,152,-27,155,-27,153,-27,157,-27,154,-27,158,-27,159,-27,137,-27}));
    AddState(127,new State(new int[]{130,117},new int[]{-25,128}));
    AddState(128,new State(new int[]{46,112,59,130,138,-72,140,-72,141,-72,142,-72,143,-72,144,-72,146,-72,147,-72,149,-72,148,-72,151,-72,150,-72,156,-72,152,-72,155,-72,153,-72,157,-72,154,-72,158,-72,159,-72,137,-72},new int[]{-26,129}));
    AddState(129,new State(-28));
    AddState(130,new State(-71));
    AddState(131,new State(new int[]{61,132}));
    AddState(132,new State(new int[]{133,133,134,134,135,135}));
    AddState(133,new State(-29));
    AddState(134,new State(-30));
    AddState(135,new State(-31));
    AddState(136,new State(new int[]{130,137}));
    AddState(137,new State(-32));
    AddState(138,new State(new int[]{130,139}));
    AddState(139,new State(-33));
    AddState(140,new State(new int[]{130,141}));
    AddState(141,new State(-34));
    AddState(142,new State(new int[]{130,143}));
    AddState(143,new State(-35));
    AddState(144,new State(new int[]{130,117},new int[]{-27,145,-25,109}));
    AddState(145,new State(-36));
    AddState(146,new State(new int[]{130,117},new int[]{-27,147,-25,109}));
    AddState(147,new State(-37));
    AddState(148,new State(-13));
    AddState(149,new State(new int[]{138,45,140,49,141,78,142,87,143,90,144,93,146,96,147,98,149,122,148,123,151,124,150,125,156,127,152,131,155,136,153,138,157,140,154,142,158,144,159,146,137,-11,127,-3},new int[]{-18,150,-19,48}));
    AddState(150,new State(-14));

    Rule[] rules=new Rule[107];
    rules[1]=new Rule(-11, new int[]{-10,127});
    rules[2]=new Rule(-10, new int[]{-12,-13,-14,-15});
    rules[3]=new Rule(-10, new int[]{126});
    rules[4]=new Rule(-13, new int[]{137});
    rules[5]=new Rule(-15, new int[]{137,-16});
    rules[6]=new Rule(-15, new int[]{});
    rules[7]=new Rule(-16, new int[]{128,129});
    rules[8]=new Rule(-16, new int[]{});
    rules[9]=new Rule(-12, new int[]{-17});
    rules[10]=new Rule(-12, new int[]{});
    rules[11]=new Rule(-12, new int[]{126});
    rules[12]=new Rule(-17, new int[]{-17,-18});
    rules[13]=new Rule(-17, new int[]{-18});
    rules[14]=new Rule(-17, new int[]{126,-18});
    rules[15]=new Rule(-18, new int[]{138,-16,139});
    rules[16]=new Rule(-18, new int[]{-19});
    rules[17]=new Rule(-19, new int[]{140,-20,-1});
    rules[18]=new Rule(-19, new int[]{141,-21,-3});
    rules[19]=new Rule(-19, new int[]{142,-20,-1});
    rules[20]=new Rule(-19, new int[]{143,-20,-1});
    rules[21]=new Rule(-19, new int[]{144,-20,-1});
    rules[22]=new Rule(-19, new int[]{146,-22});
    rules[23]=new Rule(-19, new int[]{147,-23,-24});
    rules[24]=new Rule(-19, new int[]{149});
    rules[25]=new Rule(-19, new int[]{148});
    rules[26]=new Rule(-19, new int[]{151});
    rules[27]=new Rule(-19, new int[]{150,-25});
    rules[28]=new Rule(-19, new int[]{156,-25,-26});
    rules[29]=new Rule(-19, new int[]{152,61,133});
    rules[30]=new Rule(-19, new int[]{152,61,134});
    rules[31]=new Rule(-19, new int[]{152,61,135});
    rules[32]=new Rule(-19, new int[]{155,130});
    rules[33]=new Rule(-19, new int[]{153,130});
    rules[34]=new Rule(-19, new int[]{157,130});
    rules[35]=new Rule(-19, new int[]{154,130});
    rules[36]=new Rule(-19, new int[]{158,-27});
    rules[37]=new Rule(-19, new int[]{159,-27});
    rules[38]=new Rule(-23, new int[]{130});
    rules[39]=new Rule(-23, new int[]{});
    rules[40]=new Rule(-25, new int[]{-25,46,130});
    rules[41]=new Rule(-25, new int[]{130});
    rules[42]=new Rule(-20, new int[]{-21});
    rules[43]=new Rule(-20, new int[]{});
    rules[44]=new Rule(-21, new int[]{60,130,62});
    rules[45]=new Rule(-21, new int[]{60,126,62});
    rules[46]=new Rule(-1, new int[]{-2});
    rules[47]=new Rule(-1, new int[]{-1,-28,-2});
    rules[48]=new Rule(-1, new int[]{-1,-29});
    rules[49]=new Rule(-2, new int[]{130,132});
    rules[50]=new Rule(-2, new int[]{130,134,132});
    rules[51]=new Rule(-2, new int[]{130});
    rules[52]=new Rule(-2, new int[]{130,134});
    rules[53]=new Rule(-2, new int[]{136});
    rules[54]=new Rule(-3, new int[]{-22});
    rules[55]=new Rule(-3, new int[]{-3,-28,-22});
    rules[56]=new Rule(-3, new int[]{-3,-29});
    rules[57]=new Rule(-22, new int[]{130});
    rules[58]=new Rule(-22, new int[]{131});
    rules[59]=new Rule(-27, new int[]{-25,91,93});
    rules[60]=new Rule(-27, new int[]{-25,60,-27,62});
    rules[61]=new Rule(-27, new int[]{-25});
    rules[62]=new Rule(-24, new int[]{123,-30,125});
    rules[63]=new Rule(-30, new int[]{-31});
    rules[64]=new Rule(-30, new int[]{-30,-31});
    rules[65]=new Rule(-30, new int[]{126});
    rules[66]=new Rule(-31, new int[]{-32,130,59});
    rules[67]=new Rule(-32, new int[]{-27});
    rules[68]=new Rule(-32, new int[]{-32,-27});
    rules[69]=new Rule(-28, new int[]{44});
    rules[70]=new Rule(-28, new int[]{});
    rules[71]=new Rule(-26, new int[]{59});
    rules[72]=new Rule(-26, new int[]{});
    rules[73]=new Rule(-29, new int[]{59});
    rules[74]=new Rule(-29, new int[]{58});
    rules[75]=new Rule(-29, new int[]{60});
    rules[76]=new Rule(-29, new int[]{62});
    rules[77]=new Rule(-29, new int[]{40});
    rules[78]=new Rule(-29, new int[]{41});
    rules[79]=new Rule(-29, new int[]{91});
    rules[80]=new Rule(-29, new int[]{93});
    rules[81]=new Rule(-29, new int[]{123});
    rules[82]=new Rule(-29, new int[]{125});
    rules[83]=new Rule(-14, new int[]{-14,-33});
    rules[84]=new Rule(-14, new int[]{-33});
    rules[85]=new Rule(-14, new int[]{126});
    rules[86]=new Rule(-33, new int[]{-34,-6,-35,59});
    rules[87]=new Rule(-34, new int[]{131,58});
    rules[88]=new Rule(-35, new int[]{});
    rules[89]=new Rule(-35, new int[]{-35,124,-6});
    rules[90]=new Rule(-6, new int[]{});
    rules[91]=new Rule(-6, new int[]{-7});
    rules[92]=new Rule(-7, new int[]{-4});
    rules[93]=new Rule(-7, new int[]{-9,-5});
    rules[94]=new Rule(-7, new int[]{-7,-9,-5});
    rules[95]=new Rule(-5, new int[]{});
    rules[96]=new Rule(-5, new int[]{-4});
    rules[97]=new Rule(-4, new int[]{-36});
    rules[98]=new Rule(-4, new int[]{-4,-36});
    rules[99]=new Rule(-36, new int[]{130});
    rules[100]=new Rule(-36, new int[]{136});
    rules[101]=new Rule(-36, new int[]{134});
    rules[102]=new Rule(-9, new int[]{-8});
    rules[103]=new Rule(-9, new int[]{145,130,-8});
    rules[104]=new Rule(-9, new int[]{145,130});
    rules[105]=new Rule(-8, new int[]{123,-16,125});
    rules[106]=new Rule(-8, new int[]{123,-16,126});
    this.InitRules(rules);

    this.InitNonTerminals(new string[] {"", "TokenList", "TokenDecl", "NtSymbolList", 
      "Symbols", "SymbolsOpt", "RightHandSide", "RHStermList", "Action", "PrecOptAndAction", 
      "Program", "$accept", "DefinitionSectionOpt", "Divider", "RulesSection", 
      "EpilogOpt", "CodeBlock", "Definitions", "Definition", "Declaration", "KindOpt", 
      "Kind", "NtSymbol", "TypeNameOpt", "UnionTypeConstructor", "DottedName", 
      "SemiOpt", "TypeConstructor", "CommaOpt", "BadSeparator", "DeclList", "OneDecl", 
      "TypeConstructorSeq", "ARule", "RuleProlog", "AlternativesOpt", "SymOrLit", 
      });

    aliasses = new Dictionary<int, string>();
    aliasses.Add(137, "\"%%\"");
    aliasses.Add(138, "\"%{\"");
    aliasses.Add(139, "\"%}\"");
    aliasses.Add(140, "\"%token\"");
    aliasses.Add(141, "\"%type\"");
    aliasses.Add(142, "\"%left\"");
    aliasses.Add(143, "\"%right\"");
    aliasses.Add(144, "\"%nonassoc\"");
    aliasses.Add(145, "\"%prec\"");
    aliasses.Add(146, "\"%start\"");
    aliasses.Add(147, "\"%union\"");
    aliasses.Add(148, "\"%defines\"");
    aliasses.Add(149, "\"%locations\"");
    aliasses.Add(150, "\"%namespace\"");
    aliasses.Add(151, "\"%partial\"");
    aliasses.Add(152, "\"%output\"");
    aliasses.Add(153, "\"%parsertype\"");
    aliasses.Add(154, "\"%tokentype\"");
    aliasses.Add(155, "\"%scanbasetype\"");
    aliasses.Add(156, "\"%using\"");
    aliasses.Add(157, "\"%visibility\"");
    aliasses.Add(158, "\"%YYSTYPE\"");
    aliasses.Add(159, "\"%YYLTYPE\"");
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 4: // Divider -> "%%"
{ TidyUpDefinitions(LocationStack[LocationStack.Depth-1]); }
        break;
      case 5: // EpilogOpt -> "%%", CodeBlock
{ grammar.epilogCode = LocationStack[LocationStack.Depth-1]; }
        break;
      case 7: // CodeBlock -> codeStart, codeEnd
{ /* default location action @$ = @1.Merge(@2); */ }
        break;
      case 15: // Definition -> "%{", CodeBlock, "%}"
{ grammar.prologCode.Add(LocationStack[LocationStack.Depth-2]); }
        break;
      case 17: // Declaration -> "%token", KindOpt, TokenList
{ DeclareTokens(PrecType.token, LocationStack[LocationStack.Depth-2].ToString(), ValueStack[ValueStack.Depth-1].tokenList); }
        break;
      case 18: // Declaration -> "%type", Kind, NtSymbolList
{
						  string kind = LocationStack[LocationStack.Depth-2].ToString();
						  DeclareNtKind(kind, ValueStack[ValueStack.Depth-1].stringList);
						}
        break;
      case 19: // Declaration -> "%left", KindOpt, TokenList
{ DeclareTokens(PrecType.left, LocationStack[LocationStack.Depth-2].ToString(), ValueStack[ValueStack.Depth-1].tokenList); }
        break;
      case 20: // Declaration -> "%right", KindOpt, TokenList
{ DeclareTokens(PrecType.right, LocationStack[LocationStack.Depth-2].ToString(), ValueStack[ValueStack.Depth-1].tokenList); }
        break;
      case 21: // Declaration -> "%nonassoc", KindOpt, TokenList
{ DeclareTokens(PrecType.nonassoc, LocationStack[LocationStack.Depth-2].ToString(), ValueStack[ValueStack.Depth-1].tokenList); }
        break;
      case 22: // Declaration -> "%start", NtSymbol
{ grammar.startSymbol = grammar.LookupNonTerminal(LocationStack[LocationStack.Depth-1].ToString()); }
        break;
      case 23: // Declaration -> "%union", TypeNameOpt, UnionTypeConstructor
{ grammar.unionType = LocationStack[LocationStack.Depth-1]; }
        break;
      case 24: // Declaration -> "%locations"
{  handler.ListError(LocationStack[LocationStack.Depth-1], 101); }
        break;
      case 25: // Declaration -> "%defines"
{ GPCG.Defines = true; }
        break;
      case 26: // Declaration -> "%partial"
{ grammar.IsPartial = true; }
        break;
      case 27: // Declaration -> "%namespace", DottedName
{ grammar.Namespace = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 28: // Declaration -> "%using", DottedName, SemiOpt
{ grammar.usingList.Add(LocationStack[LocationStack.Depth-2].ToString()); }
        break;
      case 29: // Declaration -> "%output", '=', filePath
{ grammar.OutFileName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 30: // Declaration -> "%output", '=', litstring
{ grammar.OutFileName = GetLitString(LocationStack[LocationStack.Depth-1]); }
        break;
      case 31: // Declaration -> "%output", '=', verbatim
{ grammar.OutFileName = GetVerbatimString(LocationStack[LocationStack.Depth-1]); }
        break;
      case 32: // Declaration -> "%scanbasetype", ident
{ grammar.ScanBaseName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 33: // Declaration -> "%parsertype", ident
{ grammar.ParserName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 34: // Declaration -> "%visibility", ident
{ grammar.Visibility = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 35: // Declaration -> "%tokentype", ident
{ grammar.TokenName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 36: // Declaration -> "%YYSTYPE", TypeConstructor
{ SetSemanticType(LocationStack[LocationStack.Depth-1]); }
        break;
      case 37: // Declaration -> "%YYLTYPE", TypeConstructor
{ grammar.LocationTypeName = LocationStack[LocationStack.Depth-1].ToString(); }
        break;
      case 38: // TypeNameOpt -> ident
{ SetSemanticType(LocationStack[LocationStack.Depth-1]); }
        break;
      case 44: // Kind -> '<', ident, '>'
{ CurrentLocationSpan = LocationStack[LocationStack.Depth-2]; }
        break;
      case 46: // TokenList -> TokenDecl
{
                          CurrentSemanticValue.tokenList = new List<TokenInfo>();
                          CurrentSemanticValue.tokenList.Add(ValueStack[ValueStack.Depth-1].tokenInfo);
                        }
        break;
      case 47: // TokenList -> TokenList, CommaOpt, TokenDecl
{ ValueStack[ValueStack.Depth-3].tokenList.Add(ValueStack[ValueStack.Depth-1].tokenInfo); CurrentSemanticValue.tokenList = ValueStack[ValueStack.Depth-3].tokenList;}
        break;
      case 48: // TokenList -> TokenList, BadSeparator
{ handler.ListError(LocationStack[LocationStack.Depth-1], 75); CurrentSemanticValue.tokenList = ValueStack[ValueStack.Depth-2].tokenList; }
        break;
      case 49: // TokenDecl -> ident, number
{ 
                          handler.ListError(LocationStack[LocationStack.Depth-1], 100); 
                          CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-2], null);
                        }
        break;
      case 50: // TokenDecl -> ident, litstring, number
{ 
                          handler.ListError(LocationStack[LocationStack.Depth-2], 100); 
                          CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-3], LocationStack[LocationStack.Depth-2]);
                        }
        break;
      case 51: // TokenDecl -> ident
{ CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-1], null); }
        break;
      case 52: // TokenDecl -> ident, litstring
{ CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-2], LocationStack[LocationStack.Depth-1]); }
        break;
      case 53: // TokenDecl -> litchar
{ CurrentSemanticValue.tokenInfo = new TokenInfo(LocationStack[LocationStack.Depth-1], null); }
        break;
      case 54: // NtSymbolList -> NtSymbol
{ 
                          CurrentSemanticValue.stringList = new List<string>();
						  CurrentSemanticValue.stringList.Add(LocationStack[LocationStack.Depth-1].ToString()); 
						}
        break;
      case 55: // NtSymbolList -> NtSymbolList, CommaOpt, NtSymbol
{ ValueStack[ValueStack.Depth-3].stringList.Add(LocationStack[LocationStack.Depth-1].ToString()); CurrentSemanticValue.stringList = ValueStack[ValueStack.Depth-3].stringList; }
        break;
      case 56: // NtSymbolList -> NtSymbolList, BadSeparator
{ handler.ListError(LocationStack[LocationStack.Depth-1], 75); CurrentSemanticValue.stringList = ValueStack[ValueStack.Depth-2].stringList; }
        break;
      case 86: // ARule -> RuleProlog, RightHandSide, AlternativesOpt, ';'
{ ClearCurrentLHS(); }
        break;
      case 87: // RuleProlog -> anchoredSymbol, ':'
{ SetCurrentLHS(LocationStack[LocationStack.Depth-2]); }
        break;
      case 90: // RightHandSide -> /* empty */
{ CurrentSemanticValue.prod = NewProduction(); FinalizeProduction(CurrentSemanticValue.prod); }
        break;
      case 91: // RightHandSide -> RHStermList
{ CurrentSemanticValue.prod = ValueStack[ValueStack.Depth-1].prod; FinalizeProduction(CurrentSemanticValue.prod); }
        break;
      case 92: // RHStermList -> Symbols
{ CurrentSemanticValue.prod = NewProduction(ValueStack[ValueStack.Depth-1].stringList, null); }
        break;
      case 93: // RHStermList -> PrecOptAndAction, SymbolsOpt
{
                          CurrentSemanticValue.prod = NewProduction(null, ValueStack[ValueStack.Depth-2].proxy);
                          AddSymbolsToProduction(CurrentSemanticValue.prod, ValueStack[ValueStack.Depth-1].stringList);
                        }
        break;
      case 94: // RHStermList -> RHStermList, PrecOptAndAction, SymbolsOpt
{
                          AddActionToProduction(ValueStack[ValueStack.Depth-3].prod, ValueStack[ValueStack.Depth-2].proxy);
                          AddSymbolsToProduction(ValueStack[ValueStack.Depth-3].prod, ValueStack[ValueStack.Depth-1].stringList);
                          CurrentSemanticValue.prod = ValueStack[ValueStack.Depth-3].prod;
                        }
        break;
      case 95: // SymbolsOpt -> /* empty */
{ CurrentSemanticValue.stringList = null; }
        break;
      case 97: // Symbols -> SymOrLit
{ CurrentSemanticValue.stringList = new List<string>(); CurrentSemanticValue.stringList.Add(LocationStack[LocationStack.Depth-1].ToString()); }
        break;
      case 98: // Symbols -> Symbols, SymOrLit
{ ValueStack[ValueStack.Depth-2].stringList.Add(LocationStack[LocationStack.Depth-1].ToString());  CurrentSemanticValue.stringList = ValueStack[ValueStack.Depth-2].stringList; }
        break;
      case 102: // PrecOptAndAction -> Action
{ CurrentSemanticValue.proxy = ValueStack[ValueStack.Depth-1].proxy; }
        break;
      case 103: // PrecOptAndAction -> "%prec", ident, Action
{ ValueStack[ValueStack.Depth-1].proxy.precedenceToken = LocationStack[LocationStack.Depth-2]; ValueStack[ValueStack.Depth-1].proxy.precedenceSpan = LocationStack[LocationStack.Depth-3]; CurrentSemanticValue.proxy = ValueStack[ValueStack.Depth-1].proxy; }
        break;
      case 104: // PrecOptAndAction -> "%prec", ident
{ CurrentSemanticValue.proxy = new ActionProxy(LocationStack[LocationStack.Depth-2], LocationStack[LocationStack.Depth-1], null); }
        break;
      case 105: // Action -> '{', CodeBlock, '}'
{ CurrentSemanticValue.proxy = new ActionProxy(null, null, CurrentLocationSpan); }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Token)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Token)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
