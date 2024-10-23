pipeline {
  agent any
  
  stages {

    stage('Checkout') {
      steps {
        git 'https://github.com/BZV83/School_Bookstore_Csharp.git'
      }
    }
    
    stage('Potato') {
      steps {
        script {
          sh '''
          echo "you are a potato"
          '''
        }
      }
    }

    stage('Build') {
      steps {
        script {
          sh 'msbuild Bookstore_Mission_11_Vick.sln /p:Configuration=Release'
        }
      }
    }

    // stage('Publish') {
    //   steps {
    //     script {
    //       bat 'msbuild Bookstore_Mission_11_Vick.csproj /p:Configuration=Release'
    //     }
    //   }
    // }
  }

  post {
    success {
      echo 'Build and Publish succeeded'
    }
    failure {
      echo 'Build or Publish failed'
    }
  }
}
