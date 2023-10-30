# Machine Learning A-Z
## Regression
### Simple Linear Regression

    y' = b_0 + (b_1(x_1))

__How do we know which slope line represents the best regression?__
Ordinary Least Squares: project each data point vertically onto the linear regression line.

y_i is the actual data point. y_j is the linear regression predictions for y_i.

__Residual__ = E_i = y_j - y_i

y_i = b_0 + (b_1(X_1)) --> b_0, b_1 such that SUM(y_j - y_i) ^ 2 is minimized.

