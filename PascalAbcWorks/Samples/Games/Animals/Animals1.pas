// Самообучающаяся игра "Угадай животное". 
// Старайтесь на вопрос "Чем отличается" вводить самый общий ответ
// Например: "Чем отличается чиж от ежа" - "Умеет летать"

uses System.Runtime.Serialization.Formatters.Binary;
uses System.IO;
uses System;

type
  [Serializable]
  Node = class
  public
    s: string;
    left,right: Node;   
    constructor(s: string);
    begin
      Self.s := s;
      left := nil;
      right := nil;
    end;
  end;

const FileName = 'animals.dat';

begin
  var formatter := new BinaryFormatter;
  var root: Node;

  Println('Загадайте животное');
  if not FileExists(FileName) then
    root := new Node('Собака')
  else
  begin
    var fs := new FileStream(FileName, FileMode.OpenOrCreate);
    root := Node(formatter.Deserialize(fs));
    fs.Close;
  end;

  var p := root;
  while p.left<>nil do
  begin
    var x := ReadlnInteger(p.s+'? (0 - Нет, 1 - Да):');
    if x=1 then 
      p := p.left
    else 
      p := p.right
  end;
  
  var x := ReadlnInteger('Это '+p.s+'? (0 - Нет, 1 - Да): ');
  if x=1 then
    Println('Я угадала!')
  else
  begin
    var s := ReadlnString('Я проиграла. Что это за животное?');
    var q := ReadlnString('Введите вопрос, отличающий это животное от '+p.s+':');
    var p1 := new Node(s);
    var p2 := new Node(p.s);
    p.s := q;
    p.left := p1;
    p.right := p2;
  end;
  
  var fs := new FileStream(FileName, FileMode.OpenOrCreate);
  formatter.Serialize(fs, root);
  fs.Close;
end.
