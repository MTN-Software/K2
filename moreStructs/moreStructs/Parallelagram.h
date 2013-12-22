#include "Quadrilateral.h"

struct side
{
	point pointOne, pointTwo;
	double length, slope;

	void Side(point One, point Two)
	{
		pointOne = One;
		pointTwo = Two;

		// slope = change in y / change in x
		slope = ((One.Coordy - Two.Coordy) / (One.Coordx - Two.Coordx));

		double changeInY = One.Coordy - Two.Coordy;					// change in y = y1 - y2
		double changeInX = One.Coordx - Two.Coordx;					// change in x = x1 - x2
		length = sqrt(pow(changeInY, 2) + pow(changeInX, 2));		// dist = sqrt(change in y ^2 + change in x ^2)


	}
};
namespace parallelagram
{
	class Parallelagram
	{
	public:
		side top, left, bottom, right, ACDiagnol, BDDiagnol;
		bool determineRectangle(side Top, side Left, side Bottom, side Right, side diagOne, side DiagTwo);

	};
}