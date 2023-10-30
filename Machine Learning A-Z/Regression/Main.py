# Sami Munir
# Machine Learning A-Z
# Regression
# Main.py

print('\nRegression')

# Simple Linear Regression
print('\nSimple Linear Regression')
print('------------------------')

# Importing the libraries
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

# Importing the dataset
dataset = pd.read_csv('./data/Data.csv')
X = dataset.iloc[:, :-1].values
y = dataset.iloc[:, -1].values
print('\nX -->\n', X)
print('\ny -->\n', y)

# Splitting the dataset into the Training set & Test set
from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=1/3, random_state=0)
print('\nX_train -->\n', X_train)
print('\nX_test -->\n', X_test)
print('\ny_train -->\n', y_train)
print('\ny_test -->\n', y_test)

# Training the Simple Linear Regression model on the training set
from sklearn.linear_model import LinearRegression
regressor = LinearRegression()
regressor.fit(X_train, y_train)
LinearRegression(copy_X=True, fit_intercept=True, n_jobs=None)

# Predicting the Test set results
y_pred = regressor.predict(X_test)