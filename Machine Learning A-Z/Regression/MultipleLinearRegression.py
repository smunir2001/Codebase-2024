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