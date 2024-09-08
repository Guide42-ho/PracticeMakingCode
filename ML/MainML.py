from sklearn.preprocessing import Normalizer
from sklearn.model_selection import train_test_split
from sklearn.neighbors import KNeighborsClassifier
from sklearn.metrics import classification_report,confusion_matrix,ConfusionMatrixDisplay
import pandas as pd
import seaborn as sb
import matplotlib.pyplot as plt
import numpy as np

# โหลดชุดข้อมูล
dataset = pd.read_csv('diabetes.csv')

# แยกข้อมูล (x) และคำตอบ (y)
x = dataset.drop("Outcome", axis=1) 
y = dataset['Outcome'].values

# แปลงข้อมูล (normalize) 
normalizer = Normalizer()
x_normalized = normalizer.fit_transform(x)

# แทนข้อมูลใหม่ ใน Dataframe
colromn = normalizer.get_feature_names_out()
print(colromn)

 # เอาเฉพาะ Colromn
dataset[colromn] = x_normalized  # ใส่ข้อมูล
# แสดงกราฟ
sb.pairplot(data= dataset ,hue= "Outcome" ,y_vars= ["Age"],
            x_vars=["Pregnancies","Glucose","BloodPressure",
                    "SkinThickness","Insulin","BMI","DiabetesPedigreeFunction"])
plt.show()

# แบ่งชุดข้อมูลเป็น training และ testing sets
x_train, x_test, y_train, y_test = train_test_split(x_normalized, y, test_size=0.3, random_state=2)

# สร้างและฝึก KNN
knn = KNeighborsClassifier(n_neighbors=8)
knn.fit(x_train, y_train)

# ทำการทำนาย
y_pred = knn.predict(x_test)
print(y_pred)
# รายงานการจำแนก
print(classification_report(y_test, y_pred))
cm = (confusion_matrix(y_true=y_test,y_pred=y_pred,labels=knn.classes_))
# ตาราง confusion_matrix
disp = ConfusionMatrixDisplay(confusion_matrix=cm)
disp.plot()
plt.show()














