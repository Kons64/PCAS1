# PCAS1
The prototype itself is pretty straight forward. each button in the main menu takes you to one of the scenarios.
There are 3 scenarios, 
first scenario: the pedestrian is first moving then stopped. There are 4 variants to this scenario:
(for coordinates please refer to page 4 of the project description)
	Initial pedestrian position at -7m, starts moving at the speed of 10kph, stops at 0m;
	Initial pedestrian position at -7m, starts moving at the speed of 10kph, stops at -2m;
	Initial pedestrian position at -7m, starts moving at the speed of 10kph, stops at -3m;
	Initial pedestrian position at -7m, starts moving at the speed of 10kph, stops at -5m;

second scenario: the pedestrian is first static then crossing the street. There are 3 variants to this scenario:
	Initial pedestrian position at 0m, and he sits for 1.5 seconds, then start to cross at the speed of 10kph;
	Initial pedestrian position at -2m, and he sits for 1.8 seconds, then start to cross at the speed of 10kph;
	Initial pedestrian position at -4m, and he sits for 1.1 seconds, then start to cross at the speed of 10kph;

Third scenario: the pedestrian is standing still. There are 3 variants to this scenario:
	The pedestrian waits at 0m away from the road;
	The pedestrian waits at -2m away from the road;
	The pedestrian waits at -4m away from the road;

The car stops moving when the simulation ends, you can click the "back" button on the bottom left of your screen to return to the last menu.
In different scenarios, the car with PCAS will never have collision with the pedestrians, or slow down when it doesn't need to.

Thank you!

Known issue: the prototype may behave weird if the project's refresh rate is low

Project proposal: https://www.cse.msu.edu/~cse435/Projects/F2021/ProjectDescriptions/2021-PCAS-Dataspeed-Capaldi-AV-Pedestrian-Project.pdf
