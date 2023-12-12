# Machine Learning A-Z
## Regression
### Simple Linear Regression

    y' = b_0 + (b_1(x_1))

__How do we know which slope line represents the best regression?__
Ordinary Least Squares: project each data point vertically onto the linear regression line.

y_i is the actual data point. y_j is the linear regression predictions for y_i.

__Residual__ = E_i = y_j - y_i

y_i = b_0 + (b_1(X_1)) --> b_0, b_1 such that SUM(y_j - y_i) ^ 2 is minimized.

### Multiple Linear Regression
Same as linear regression, however we'll have more than one feature.

y = b_0  + b_1X_1 + b_2X_2 + ... + b_nX_n

dependent variable = y-intercept + (slope coefficient 1) * (independent variable 1) + (...) * (...) + ...

### Assumptions of Linear Regression
1. Linearity
* linear relationship between Y and each X
2. Homoscedasticity
* equal variance
3. Multivariate Normality
* normality of error distribution
4. Independence
* of observations. Includes "no auto-correlation" (no patterns in the data)
5. Lack of Multicollinearity
* predictors are not correlated with each other
6. The Outlier Check

### Dummy Variables
For each categorical label, create a new column for each (0 or 1).
* but do not include all but __one__ dummy variable (because you may end up duplicating variables)