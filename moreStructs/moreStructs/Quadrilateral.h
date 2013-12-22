#pragma once

struct point									// create data type "point"
{
	double Coordx, Coordy;
	void Point(double x, double y)
	{
		Coordx = x;
		Coordy = y;
	}
};


class Quadrilateral								// create class Quadrilateral
{
public:
	Quadrilateral();
	~Quadrilateral();
	point A, B, C, D;
};