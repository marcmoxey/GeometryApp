
### **4. Geometry Library**
```markdown
# Geometry Library

A class library that provides geometric calculations, such as calculating the area and perimeter of shapes (e.g., circle, rectangle, triangle).

## Features
- **CalculateCircleArea**: Calculates the area of a circle.
- **CalculateRectanglePerimeter**: Calculates the perimeter of a rectangle.
- **CalculateTriangleArea**: Calculates the area of a triangle.

## How to Use
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build the `GeometryUtilities` class library.
4. Add a reference to the `GeometryUtilities` library in your console application.
5. Use the `GeometryCalculator` class in your code.

### Example
```csharp
using GeometryUtilities;

double circleArea = GeometryCalculator.CalculateCircleArea(5); // 78.54
double rectanglePerimeter = GeometryCalculator.CalculateRectanglePerimeter(4, 6); // 20
