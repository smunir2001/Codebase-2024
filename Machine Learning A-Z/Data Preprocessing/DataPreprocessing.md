Sami Munir | October 14, 2023 | smunir2001@gmail.com
# Machine Learning A-Z
## Data Preprocessing
### The Machine Learning Process
1. Data preprocessing
    * Import the data
    * Clean the data
    * Split into training & test sets
2. Modelling
    * Build the model
    * Train the model
    * Make prediction
3. Evaluation
    * Calculate performance metrics
    * Make a verdict
### Training Set & Test Set
__Splitting the data set:__ Split the data set by the 80/20 rule where 80% of the data set is allocated for training the model and the remaining 20% of the data set is for comparing predicted values to actual values.

### Feature Scaling
Feature scaling is applied to columns (never applied across data columns).
* Normalization
    * The process in the which we take the minimum inside a column and subtract it from every single value in the column, and then dividing it by the difference between the maximum and minimum.
    * [0, 1]
* Standardization
    * The process is the same as normalization except we wil subtract the minimum value from each column by the average, and then divide by the standard deviation.
    * [-3, +3]

### Features & the Dependent Variable Vector
__Features:__ the columns with which you are going to predict the dependent variable (containing information).

__Dependent Variable Vector:__ the last column for which we want to predict.
### Taking Care of Missing Data
Missing data can cause errors when training the machine learning model.

Ways to handle missing data:
1. Remove the data observation that contains missing data (works if you have a really large data set).
2. Replace the missing data by the average of all the values within that same column (feature).

### Encoding Categorical Data
Encoding non-numerical values into numerical values.

__One hot encoding:__ turning *one* column into *three* columns (e.g., each country gets it own identity vectory).

### Splitting the Data Set
Apply feature scaling after splitting the data set into the training set and the test set.

This is because the test set is supposed to be a brand new set on which the machine learning model will be tested and analyzed.
* This will also prevent data leakage.

__Training Set:__

__Test Set:__

### Feature Scaling
Simply consists of scaling all your features to make sure they take values on the same scale.

__Standardization__

x_standard = (x - mean(x)) / standard_deviation(x)

Works well always!

__Normalization__

x_norm = (x - min(x)) / (max(x) - min(x))

Recommended when you have a normal distribution in most of your features.

Apply standardization on matrix of features for the train_set & the test_set.

__Do you apply feature scaling to the matrix of features that are dummy variables?__
* NO