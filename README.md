Resumen Completo de la Refactorización
ANTES: Código Monolítico (Todo en una clase)

 DESPUÉS: Se mejoro la arquitectora, mucho más limpia, facil de seguir utilizando patrones de diseño
 Nueva Estructura (10 archivos vs 1)

Classes/
  Enums.cs                    
  IFormaGeometrica.cs         
  FormaGeometrica.cs          
  FormaGeometricaFactory.cs   
  RecursosHelper.cs           
  Formas/
    Cuadrado.cs            
    Circulo.cs             
    TrianguloEquilatero.cs 
    Trapecio.cs             NUEVO
Resources/
  Textos.resx                ← Español
  Textos.en.resx             ← Inglés
  Textos.it.resx             ← NUEVO: Italiano

  Se utilizaron Enums, Interfaces, Factory Pattern, LinQ, Se utilizo un diccionario con resx (se podría haber implementado con un hash, pero en la actualizad estoy modificando los hash a resx )
  Bueno y valga la redundancia usando todos los Principios de SOLID, para este contexto lo podríamos aplicar en lo siguiente:
  
    Single Responsibility:	Cada clase tiene UNA responsabilidad
    Open/Closed:	Abierto a extensión (nuevas formas), cerrado a modificación
    Liskov: Substitution	Todas las formas son intercambiables vía IFormaGeometrica
    Interface Segregation:	Interfaz pequeña y específica
    Dependency Inversion:	Depende de IFormaGeometrica, no de clases concretas

    En cuanto a los test, se modificaron lo existentes para poder utilizar los enums y de jar de usar lo números
    Y se agregaron nuevos para mejorar el coverage del proyecto.

    Eso sería todo.
