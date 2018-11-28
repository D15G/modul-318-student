# Code Guidelines
**Authors**: Tuan Binh Tran, Dominic Pohland - 28.11.2018

# Zweck von Code Guidelines
Die Idee von Code Guidelines sind folgende:

- Der Code ist im Team einheitlich.
- Der Code ist für alle im Team verständlich.
- Der Code ist wartbar.
- Der Code ist lesbar.


# Allgemein
Es werden Tabs für Einrückungen verwendet anstatt Spaces (Leertaste).

Es wird alles in englisch geschrieben, mit Ausnahme der Kommentare (Deutsch)



# Naming Conventions

## Variablen
Variablen verwenden camelCase und werden gleich beim Deklarieren initialisiert. 
Variablen verwenden keine Abkürzungen. (usrGrp -> userGroup)

**BEISPIEL:**
```
string namingConventions = null;
int number = null;
```

**NOT:**
```
string NamingConventions;
string Number;
```

## Properties
Properties sind in PascalCase geschrieben und sind Plural.

**BEISPIEL:**
```
public string FirstName { get; set;}
```
**NOT:**
```
public string firstname {get; set;}
```


## Methoden
Methoden werden in PascalCase geschrieben.
Methoden fangen mit einem Verb an und beschreibt deren Funktion.
Brackets fangen auf einer neuen Linie an.

**BEISPIEL:**
```
public string DoSomething ()
{
    //code
}
```
**NOT:**
```
public string haus {
    //code
}
```
Bei allen public Methoden muss ein Summary und und Returns stehen.

**BEISPIEL:**
```
/// 
```



## Klassen
Klassen fangen mit einem Grossbuchstaben an und sind Singular.

**BEISPIEL:**
```
public class Tree
{
    //Properties
}
```
**NOT:**
```

```

## Kommentare
Kurze und verständliche Kommentare vor Methoden, WENN Methodename nicht selbsterklärend ist.
Kommentare sind in Deutsch geschrieben.
Nach einem Kommentar ist KEINE Leerezeile.

**BEISPIEL:**
```
// Gibt den string in UPPERCASE zurück.
DoSomething (string text)
{
    // code
}
```
**NOT:**
```
```

## GUI-Controls
Folgenden Controls starten mit folgenden Prefix und danach mit einem Grossbuchstaben.
|Control|Name|
|-------|----|
|Label|lbl...|
|Button|btn...|
|ComboBox|cbo...|
|TextBox|txt...|
|ListBox|lst...|
|PictureBox|pic...|
|Timer|tmr...|
|RadioButton|opt...|
|CheckBox|chk...|
|GroupBox|grp...|
|Panel|pnl...|

GUI-Events: Standard.

**BEISPIEL:**
```
lblName
btnBerechnen
```

**NOT:**
```
labellorem
buttonSchliessen
```
