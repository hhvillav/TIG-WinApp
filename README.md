# TIG-WinApp
Aplicación Windows de demostración para Tendencias en Ingeniería de software

Estructura estática


## Diagrama de casos de uso
Con base a los requerimientos identificados se pueden identificar los casos de uso de la aplicación, como se representan en el siguiente diagrama:

![Diagrama de casos de uso](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaCasosDeUso.png?raw=true)

## Estructura estática
la estructura estática de la aplicación está representada por varios modelos que se presentan a continuación:

### Diagrama de paquetes
Los paquetes representan grandes módulos a nivel de código fuente que agrupan caracterśiticas en común

![Diagrama de paquetes](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaPaquetes.png?raw=true)

### Diagrama de clases
Gran parte de la arquitectura de la aplicación es definida por la herramienta con la que es construida, en éste caso Visual studio .NET. La jerarquía de componentes visuales relevantes para contextualizar la solución aparece a continuación:

![Diagrama de clases](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaDeclasesDotNet.png?raw=true)

Internamente dentro del formulario que recibe eventos aparecen otro tipo de relaciones, como se ilustra en el siguiente diagrama:

![Diagrama de clases](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaClases.jpeg?raw=true)


## Modelado del comportamiento
### Diagramas de secuencia
Como ejemplificación de algunos flujos se tomaron los siguientes diagramas de  secuencia:

#### Diagrama caso de uso Consultar Clientes.

![Consultar Clientes](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaSecuenciaConsultar.png?raw=true)


#### Diagrama caso de uso Grabar Cliente

![Grabar Cliente](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaSecuenciaGrabar.png?raw=true)

#### Diagrama de estados
El diagrama de estados representa la transición de un estado a otro dentro del sistema

![Diagrama de estados](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaEstados.png?raw=true)

## Modelo de datos
### Diagrama Relacional

![Diagrama Relacional](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaRelacional.PNG?raw=true)

### Diagrama Entidad Relación

![Diagrama Entidad Relación](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaER.png?raw=true)


# Modelo arquitectónico
## Diagrama de componentes

Los componentes representan elementos estructurales de la aplicación.

![Diagrama de componentes](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/DiagramaComponentes.png?raw=true)


## Modelo de despliegue
El modelo de despliegue presenta la disposición final del software desde la perspectiva del usuario

![Modelo de despliegue](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/Diagrama%20de%20despliegue.png?raw=true)


##Descripción de la arquitectura

Debido a que aparecen dos grupos de eventos desconectados, se puede realizar la separación de la aplicación en dos módulos independientes. 

![Arquitectura](https://github.com/hhvillav/TIG-WinApp/blob/main/diagrams/Arquitectura.png?raw=true)


Módulo de gestión de datos
Se encarga de la gestión de la base de datos de ventas permitiendo realizar las operaciones de registro, consulta y eliminación.

Módulo de Acceso a web service
Se encarga de la configuración y acceso de un Cliente Web SOAP al servidor con el fin de solicitar una operación.

Al observar tanto la nomenclatura de los símbolos como la organización de los componentes se puede intuir que es una aplicación de prueba realizada con fines pedagógicos, para identificar el uso de la tecnología.
