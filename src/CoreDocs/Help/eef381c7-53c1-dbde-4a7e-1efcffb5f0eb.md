# TerrainData.Id Property 
 

\[Missing <summary> documentation for "P:GameFramework.Contracts.Abstractions.Domain.TerrainData.Id"\]

**Namespace:**&nbsp;<a href="cbea2cac-4b61-7f85-9e15-c3347ab319fc">GameFramework.Contracts.Abstractions.Domain</a><br />**Assembly:**&nbsp;GameFramework.Contracts (in GameFramework.Contracts.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[KeyAttribute]
[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
public int Id { get; set; }
```

**VB**<br />
``` VB
<KeyAttribute>
<DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)>
Public Property Id As Integer
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As TerrainData
Dim value As Integer

value = instance.Id

instance.Id = value
```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">Int32</a>

#### Implements
<a href="ef64375f-93e5-c996-3b50-8c0f83fffa31">ITerrainData.Id</a><br />

## See Also


#### Reference
<a href="0fdaa37e-ba26-4e5f-3211-ffc17adcac50">TerrainData Class</a><br /><a href="cbea2cac-4b61-7f85-9e15-c3347ab319fc">GameFramework.Contracts.Abstractions.Domain Namespace</a><br />