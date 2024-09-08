from sklearn.neighbors import KNeighborsClassifier
from sklearn.preprocessing import Normalizer
from sklearn.model_selection import train_test_split
from sklearn.metrics import classification_report,confusion_matrix,ConfusionMatrixDisplay
import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sb


# โหลดชุดข้อมูล
dataset = pd.read_csv('diabetes.csv')

#print(dataset.head())

# แยกคุณข้อมูล (x) และคำตอบ (y)
x = dataset.drop("Outcome", axis=1) 
y = dataset['Outcome'] .values

# แปลงข้อมูล (normalize) 
normalizer = Normalizer()
x_normalized = normalizer.fit_transform(x)

# แทนข้อมูลใหม่ ใน Dataframe
colromn = normalizer.get_feature_names_out() # เอาเฉพาะ Colromn
dataset[colromn] = x_normalized  # ใส่ข้อมูล
# แสดงกราฟ
sb.pairplot(data= dataset ,hue= "Outcome" ,y_vars= ["Age"],x_vars=["Glucose"])
plt.show()

# แบ่งชุดข้อมูลเป็น training และ testing sets
x_train, x_test, y_train, y_test  = train_test_split(x_normalized,y , test_size=0.3 ,random_state=0)



##หาค่าที่ดีที่สุด k ให้ model
#k_neighbors = np.arange(1,9) # Loop 8
# #เก็บข้อมูล (ทำกราฟ)
#train_score = np.empty(len(k_neighbors))
#test_score = np.empty(len(k_neighbors))#
#for i,k in enumerate(k_neighbors):
#    knn = KNeighborsClassifier(n_neighbors= k )
#    score = knn.fit(x_train,y_train)
#    #วัดประสิทธิภาพ
#    train_score[i] = knn.score(x_train,y_train)
#    test_score[i] = knn.score(x_test,y_test)#
#    print("predict",test_score[i])#
##กราฟหาค่า k 1-8
#plt.title("Compare k Value in Model")
#plt.plot(k_neighbors,train_score,label ="train Score")
#plt.plot(k_neighbors,test_score,label ="test Score")
#plt.xlabel("k number")
#plt.legend()
#plt.ylabel("score")
#plt.show()


# สร้างและฝึกตัวแยกประเภท KNN
knn = KNeighborsClassifier(n_neighbors=8)
knn.fit(x_train, y_train)#
# ทำการทำนาย
y_pred = knn.predict(x_test)#
# พิมพ์รายงานการจำแนก
cm = (confusion_matrix(y_true=y_test,y_pred=y_pred,labels=knn.classes_))
disp = ConfusionMatrixDisplay(confusion_matrix=cm)
disp.plot()
plt.show()















