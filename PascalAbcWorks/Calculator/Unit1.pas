Unit Unit1;

interface

uses System, System.Drawing, System.Windows.Forms;

type
  Form1 = class(Form)
    procedure button1_Click(sender: Object; e: EventArgs);
    procedure label2_Click(sender: Object; e: EventArgs);
    procedure button2_Click(sender: Object; e: EventArgs);
    procedure button3_Click(sender: Object; e: EventArgs);
    procedure button4_Click(sender: Object; e: EventArgs);
    procedure button5_Click(sender: Object; e: EventArgs);
    procedure button6_Click(sender: Object; e: EventArgs);
    procedure button7_Click(sender: Object; e: EventArgs);
    procedure button8_Click(sender: Object; e: EventArgs);
    procedure button9_Click(sender: Object; e: EventArgs);
    procedure button10_Click(sender: Object; e: EventArgs);
    procedure button11_Click(sender: Object; e: EventArgs);
    procedure button12_Click(sender: Object; e: EventArgs);
    procedure button13_Click(sender: Object; e: EventArgs);
    procedure button14_Click(sender: Object; e: EventArgs);
    procedure button16_Click(sender: Object; e: EventArgs);
  {$region FormDesigner}
  internal
    {$resource Unit1.Form1.resources}
    label1: &Label;
    label2: &Label;
    label3: &Label;
    button2: Button;
    button3: Button;
    button4: Button;
    button5: Button;
    button6: Button;
    button7: Button;
    button8: Button;
    button9: Button;
    button10: Button;
    button12: Button;
    button13: Button;
    button14: Button;
    button11: Button;
    button16: Button;
    button1: Button;
    {$include Unit1.Form1.inc}
  {$endregion FormDesigner}
  public
    constructor;
    begin
      InitializeComponent;
    end;
  end;

implementation
var num1, num2, answer:real;
    sign:char;
    total:string;

procedure Form1.button1_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '1';
end;

procedure Form1.label2_Click(sender: Object; e: EventArgs);
begin
end;

procedure Form1.button2_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '2';
end;

procedure Form1.button3_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '3';
end;

procedure Form1.button4_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '4';
end;

procedure Form1.button5_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '5';
end;

procedure Form1.button6_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '6';
end;

procedure Form1.button7_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '7';
end;

procedure Form1.button8_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '8';
end;

procedure Form1.button9_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '9';
end;

procedure Form1.button10_Click(sender: Object; e: EventArgs);
begin
  Label1.Text := Label1.Text + '0';
end;

procedure Form1.button11_Click(sender: Object; e: EventArgs);
begin
  num1 := StrToReal(Label1.Text);
  Label1.Text := ' ';
  sign := '+';
end;

procedure Form1.button12_Click(sender: Object; e: EventArgs);
begin
  num1 := StrToReal(Label1.Text);
  Label1.Text := ' ';
  sign := '-';
end;

procedure Form1.button13_Click(sender: Object; e: EventArgs);
begin
  num1 := StrToReal(Label1.Text);
  Label1.Text := ' ';
  sign := '/';
end;

procedure Form1.button14_Click(sender: Object; e: EventArgs);
begin
  num1 := StrToReal(Label1.Text);
  Label1.Text := ' ';
  sign := '*';
end;

procedure Form1.button16_Click(sender: Object; e: EventArgs);
begin
  num2 := StrToReal(Label1.Text);
  if sign = '+' then
    answer := num1+num2;
  if sign = '-' then
    answer := num1-num2;
  if sign = '*' then
    answer := num1*num2;
  if sign = '/' then
    answer := num1/num2;
  Str(answer : 15 : 2, total);
  Label3.Text := total;
  Label1.Text := ' '; 
end;

end.
