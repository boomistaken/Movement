### Cartesian vs Polar coordinates

Tijdens dit project komen de termen 'cartesian coordinates' en 'Polar coordinates' veel voor.

- cartesian (eindpunt bekend, hoek+lengte onbekend)
- polar (hoek+lengte bekend, eindpunt onbekend)

### Probleem

Van cartesian naar polar:
- Persoon moet in juiste richting roteren, en vervolgens 'vooruit' lopen (eindpunt bekend, hoek onbekend)

Van Polar naar cartesian:
- Auto staat in een bepaalde richting (hoek tov x-as), en rijdt 'vooruit' met een bepaalde snelheid (eindpunt onbekend, hoek bekend)

Beide:
- Kanonskogel wordt met bepaalde snelheid in een bepaalde richting geschoten. Kogel is onder invloed van zwaartekracht.

### Implementatie

In het volgende artikel wordt het verschil in z'n algemeenheid uitgelegd: [polar vs cartesian](https://www.mathsisfun.com/polar-cartesian-coordinates.html)

Wij kunnen bestaande Math libraries gebruiken. Dat is iets makkelijker dan in bovenstaand artikel staat.

Converteren van cartesian naar polar (x+y bekend, hoek+afstand onbekend):

    magnitude = Math.sqrt((x*x) + (y*y));
    angle = Math.atan2(y, x);

Converteren van polar naar cartesian (hoek+afstand bekend, x+y onbekend):

	x = Math.cos(angle) * magnitude;
	y = Math.sin(angle) * magnitude;

### Keywords

- vector
- position
- velocity
- acceleration
- forces
- mass
