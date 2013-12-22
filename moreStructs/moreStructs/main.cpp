#include <iostream>
#include <conio.h>
#include <math.h>
#include "Parallelagram.h"



// class Quadrilateral function definitions
Quadrilateral::Quadrilateral()
{
	double ax, ay, bx, by, cx, cy, dx, dy;								// declare variables

	std::cout << "Enter Coords for A (top left)\n\n";					// prompt to enter
	std::cout << "x: ";
	std::cin >> ax;
	std::cout << "y: ";
	std::cin >> ay;

	std::cout << "\n\nEnter Coords for B (top right)\n\n";				// prompt to enter
	std::cout << "x: ";
	std::cin >> bx;
	std::cout << "y: ";
	std::cin >> by;

	std::cout << "\n\nEnter Coords for C (bottom right)\n\n";			// prompt to enter
	std::cout << "x: ";
	std::cin >> cx;
	std::cout << "y: ";
	std::cin >> cy;

	std::cout << "\n\nEnter Coords for D (bottom left)\n\n";			// prompt to enter
	std::cout << "x: ";
	std::cin >> dx;
	std::cout << "y: ";
	std::cin >> dy;

	A.Point(ax, ay);									// set x,y vals for point A
	B.Point(bx, by);									// set x,y vals for point B
	C.Point(cx, cy);									// set x,y vals for point C
	D.Point(dx, dy);									// set x,y vals for point D

}

Quadrilateral::~Quadrilateral()
{

}

bool parallelagram::Parallelagram::determineRectangle(side Top, side Left, side Bottom, side Right, side diagOne, side DiagTwo)
{
	if ((top.slope != (-1 / (left.slope))) || (top.slope != (-1 / (right.slope))) || (bottom.slope != (-1 / (left.slope))) || (bottom.slope != (-1 / (right.slope))) || (top.length != bottom.length) || (right.length != left.length) || (top.slope != bottom.slope))
	{
		return false;
	}
	else
	{
		return true;
	}
}

int main()												// main funtion
{
	Quadrilateral c_quad;								// create c_quad as Quadrilateral
	parallelagram::Parallelagram par;					// initialize a parallelagram
	side t, l, b, r, acd, bdd;
	par.top.Side(c_quad.A, c_quad.B);
	par.left.Side(c_quad.A, c_quad.D);
	par.bottom.Side(c_quad.D, c_quad.C);
	par.right.Side(c_quad.B, c_quad.C);
	par.ACDiagnol.Side(c_quad.A, c_quad.C);
	par.BDDiagnol.Side(c_quad.B, c_quad.D);
	t = par.top;
	l = par.left;
	b = par.bottom;
	r = par.right;
	acd = par.ACDiagnol;
	bdd = par.BDDiagnol;
	bool isRectangle = par.determineRectangle(t, l, b, r, acd, bdd);
	switch (isRectangle)
	{
	case true:
		std::cout << "\n\n\nIt is a rectangle!";
		break;
	case false:
		std::cout << "\n\n\nIt is not a rectangle.";
		break;
	default:
		std::cout << "\n\n\nIt isn't a rectangle, but it isn't not a rectangle...";
	}

	_getch();
	c_quad.~Quadrilateral();

	return 0;
}