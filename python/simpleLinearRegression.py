X=[1,2,3,4,5]
Y=[2+5*x for x in X]
def linearRegression(X,Y,alpha=0.001,iterations=100000):
	m=len(Y)
	theta0=0 
	theta1=0 
	for _ in range(iterations):
		#formula for the loss function: sum[(y-pred)**2]/m
		predictions=[theta0+theta1*x for x in X]
		dTheta0=(2)*sum([Y[i]-predictions[i] for i in range(m)]) *(-1/m)
		dTheta1=(2)*sum([(Y[i]-predictions[i])*X[i] for i in range(m)])*(-1/m)
		theta0-=dTheta0 *alpha
		theta1-=dTheta1 *alpha
	return theta0,theta1
theta0,theta1=linearRegression(X,Y)
print(f"linear regression returned function:\tf(x)={theta0}+{theta1}*x")
