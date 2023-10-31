# Sami Munir
# Machine Learning A-Z
# Regression
# MultipleLinearRegression.py

print('\nRegression')

# Simple Linear Regression
print('\nMultiple Linear Regression')
print('------------------------')

# Importing the libraries
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

# Importing the dataset
dataset = pd.read_csv('./data/Startups_Data.csv')
X = dataset.iloc[:, :-1].values
y = dataset.iloc[:, -1].values
print('\nX -->\n', X)
print('\ny -->\n', y)

# Encoding categorical data
from sklearn.compose import ColumnTransformer
from sklearn.preprocessing import OneHotEncoder
ct = ColumnTransformer(transformers=[('encoder', OneHotEncoder(), [3])], remainder='passthrough')
X = np.array(ct.fit_transform(X))
print('\nX -->\n', X)

# Splitting the dataset into the Training set & Test set
from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=0)
print('\nX_train -->\n', X_train)
print('\nX_test -->\n', X_test)
print('\ny_train -->\n', y_train)
print('\ny_test -->\n', y_test)