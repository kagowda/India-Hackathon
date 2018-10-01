# Service Fabric India Hackathon
**October 4th-5th in Bengaluru, 8th – 9th in Mumbai**

## Overview

Azure Service Fabric is a distributed systems platform that makes it easy to package, deploy, and manage scalable and reliable microservices and containers. Service Fabric also addresses the significant challenges in developing and managing cloud-native applications.

Service Fabric Hackathon is focused on ‘Lift and Shift’ developer scenario to move a legacy application by containerizing it into Azure by using Service fabric Containers platform. The challenges are geared towards teaching you the basic/real-world features of Service fabric. The initial challenges start easy and help a new person understand concepts of containers and Service fabric and later challenges lets developer build expertise around powerful features of Service fabric.

## Event Structure
This is a team-based event. Each team consisting of 3 team members will storm through challenges. The challenges are defined but the solutions are not. You will have to explore Service fabric docs and internet to define and implement solutions.
We have planned the following structure for you 
### DAY1
  * Talk from Speakers 
  * Setup of your laptop environment if you haven’t finished pre-requisites
  * Ready Set Go! Start your challenges 
  * LUNCH
  * Chale Chalo! Keep storming through your challenges
  * Speaker present on topics covered in first few challenges
  * Q & A - Ask Anything except food 😊
  * Disable Azure cluster resources before heading home
### DAY 2
  * Pick a new challenge and breeze through it 
  * If not breezing, sweat through it! 
  * LUNCH
  * Free Hand- Create new website/services and deploy to Service fabric
  * Presentation on technical concepts covered
  * Q&A
  * Disable Azure cluster resources before heading home
  * Closing ceremony – With awards and complements
## Feedback
Feedback is super important to us. We need to know what’s working well and what isn’t. We will run a short survey at the end of the event to get your thoughts. However, you can grab a proctor at any time and ask them to pass on feedback directly to us.

If you have feedback about documentation, please comment, raise an issue or open a pull-request against the offending document. Our open documentation is all backed by GitHub so it should be super easy to do!

If you have issues with Service Fabric, its tooling, or just a great idea on how to improve the product, please submit in the survey or create an issue directly on the Service Fabric issue page or submit a user voice post.

If all else fails, stand on a chair and start shouting! I’m sure someone will take notice soon enough!

## Setup & Prerequisites
To ensure you have the best experience whilst completing the challenges, we have put together a list of tools you’ll need to install to get setup.

We will provide an Azure subscription with credit, but please ensure you bring your own laptop and have followed one of the "Set up your development environment" guides below:

### REQUIRED
  * Service Fabric SDK, runtime and tools
    * [Windows](https://aka.ms/DevWindows)
    * [Linux](https://aka.ms/DevLinux)
    * [MacOS](https://aka.ms/DevMacOS)
  * [PowerShell](https://docs.microsoft.com/en-us/powershell/) (Should be installed by default on Windows OS)
  * Docker
    * [Windows](https://store.docker.com/editions/community/docker-ce-desktop-windows?tab=description)
    * [Mac](https://aka.ms/DevLinux)
    * [Ubuntu](https://docs.docker.com/install/linux/docker-ce/ubuntu/)
  * [Visual Studio 2017 15.7+](https://visualstudio.microsoft.com/downloads/)
  * [Git](https://git-scm.com/downloads)

### OPTIONAL
  * [.NET Core](https://www.microsoft.com/net/download/dotnet-core/2.1)
  * [Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest)
  * [Service Fabric CLI](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cli)
  * [Service Fabric Mesh Tooling](https://docs.microsoft.com/en-us/azure/service-fabric-mesh/service-fabric-mesh-howto-setup-developer-environment-sdk)
## Azure Subscription
Azure Subscription – Azure pass code will be passed on to you to give you access to Azure resources for a month from activation. The subscription will give access to all Azure 1st party services which is what is needed for your challenges.  

Redeem pass code by clicking this [link](https://www.microsoftazurepass.com/) and following process listed [here](https://www.microsoftazurepass.com/Home/HowTo.).
## Up and Running 
Make sure you have finished and installed all the Pre-requisites. Make sure the following is running on your system
1)	Docker is up and running – You will see docker icon in your task bar. Click on the icon and ensure the docker is up and running. 

2)	Service Fabric local cluster is running - Service Fabric Local Cluster Manager icon should appear in the notification/ system tray. If not, search for “Service Fabric Local Cluster Manager” in the Windows search and launch it. Right click on the cluster icon and select “Setup Local Cluster -> 1 Node”. Wait for the notification to appear as “Local Cluster setup completed successfully”. It should take couple of minutes.

3)	Right click on the Service Fabric cluster icon in tray and select “Manage Local Cluster”. This should bring up the Service Fabric Explorer in a browser. You shouldn’t see any errors on the screen and be able to browser through the nodes, system services etc. Take few minutes to go through the document below to understand the functionality of Service Fabric Explorer.  This is a key app that you will be using to visualize and monitor your applications on Service Fabric cluster.

    https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-visualizing-your-cluster

4)	Open Visual Studio and verify the version is greater than 15.7.

## Challenges
Welcome to Service Fabric Challenge! The challenges are intended to be a challenge! They should help you understand the problem, the potential solutions, and give you experience trying to implement. Useful resources will be referenced to help you work through each challenge but step by step instructions will not be provided. To ensure you progress at a good pace try to make sure that your workload is divided between team members. This may mean anticipating work that might be required in a later challenge.

### 1.	LIFT AND SHIFT EXISTING .NET APPLICATION AS CONTAINERS USING SERVICE FABRIC

Among many scenarios where Azure Service Fabric shines, one of the latest has been the lift and shift legacy applications into Azure with minimal code changes on Service Fabric. With Windows Service 2008 and Windows Server 2005 getting out of support, there exists thousands of .net applications in want of supported environment. Many organizations are taking advantage of this situation and looking for ways to move their legacy business-critical applications into cloud with Service Fabric and why not? Azure Service Fabric gives your legacy application all the tested feature of scale, availability, reliability, and resilience in one shot with minimal code change.

The legacy application can be moved into Service Fabric by containerizing java legacy with Linux containers and .Net with Windows containers. As of now, Service Fabric is the only product that support moving .Net legacy apps with Windows containers into cloud. Through this challenge, we would like to showcase this momentum to all the partners, ISV, and customer participants in the hackathon.

Use following application in the repository for challenges 1.1 to 1.5- https://github.com/kagowda/India-Hackathon/tree/master/eshopwebformApplication/eShopLegacyWebFormsSolution 

#### 1.1.	Containerize legacy .Net application using Service Fabric as container orchestrator in Visual Studio

Build the solution and run the application to see an eShop web page in the browser.

In this challenge, containerize the typical Asp.net IIS application using Service Fabric. We have designed the challenge to not give any specific resources around this and find your way in Service Fabric docs. How’s that!! 

**Resources:**  
https://azure.microsoft.com/en-in/blog/container-tooling-for-service-fabric/  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-host-app-in-a-container  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-get-started-containers  


#### 1.2.	Build and publish to local cluster and run application

Publish the container to local Service Fabric cluster and run the application. Take a point of the port you have exposed for service host in your manifest files. Use this port to access your application on local cluster. Remember your buddy, Service Fabric Explorer. Ha! Very detailed instruction, isn’t it? 

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-host-app-in-a-container   
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-service-manifest-resources  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-get-started-containers   

#### 1.3.	Push container to Azure Container Registry (ACR)

Simple challenge to create new Azure container registry and then push the above container image into registry. The previous challenges have created containers on your local machine. Find the container and push the container image to newly created ACR. Use your Azure pass subscription to create this resource.

**Resources:**  
https://docs.microsoft.com/en-us/azure/container-registry/container-registry-get-started-powershell   
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-get-started-containers#push-the-image-to-the-container-registry   
https://docs.docker.com/engine/reference/commandline/docker/  

#### 1.4.	Create Azure Service Fabric cluster and access Service Fabric Explorer
Now let’s walk these containers to Azure. First, create Service Fabric cluster on Azure and deploy the containerized services to onto that cluster. Successful completion will leave you with a healthy Service Fabric cluster and container instances.

Do not move out of the challenge unless you can run your eShop application in a browser.

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-creation-via-portal  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-creation-via-arm  
https://azure.microsoft.com/en-in/blog/create-service-fabric-clusters-visual-studio/  

#### 1.5.	Upgrade the application and parametrize environment variables
In this challenge, you will enable parameterization of application configuration for different environments. We will also roll-out an upgrade to the Service Fabric application. 

If you open SiteMaster.cs, we see that it reads environment variable “eShopTitle” to set page title. Let’s put environment variable in service manifest and parameterize this at application level and specify different values for local cluster and Azure cloud. 

Make changes and upgrade the application to cluster again. Watch the upgrade process through upgrade domains with zero downtime for your application. Also see how the title behaves differently in the local and Azure environment.

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-how-to-parameterize-configuration-files   
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-how-to-specify-environment-variables   
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-application-upgrade  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-application-upgrade-tutorial  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-application-upgrade-tutorial-powershell  

#### 1.6.	Add inter service communication with DNS

From here on – Use the following application of eshopAppWithWepApi https://github.com/kagowda/India-Hackathon/tree/master/eshopAppWithWepApi .

Any complex application is going to have multiple services talking to each other and DNS is the natural medium to resolve another endpoint and connect to it (whatever may the transport protocol be). Service Fabric has an inbuilt DNS service which let’s you do service discovery inside the cluster without changing your legacy application code.  

This application contains a webapi service along with Asp.net eshopwebform application which you have already seen in above challenges. We have added a service to showcase the inter communication among services. 

The solution is already containerized for Service Fabric. Delete existing application in your Azure cluster by using Service Fabric explorer. 

Enable DNS for your cluster in Azure and update eshopwebform application to use DNS url of webapi to access the service.  Test the service locally and then publish to Azure Service Fabric cluster. Access your application and make sure everything is running the same.

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-dnsservice  

#### 1.7.	Scale the containers by modifying the instance count of your containers

Azure Service Fabric makes it easy to build scalable applications by managing the services, partitions, and replicas on the nodes of a cluster. Running many workloads on the same hardware not only enables maximum resource utilization, but also provides flexibility in terms of how you choose to scale your workloads.

In this challenge, you will look at understanding manual scaling, which can also be done programmatically. But programmatical scaling is not included here, you can always explore more. 
##### 1.7.1.	Service/Container instance scaling
Look at your container instances in your cluster. You should see that containers are running on all the VMs as instance count for containers in your manifest is set to -1. 

Reduce the instance count to 1 and republish to observe the container instance count changes in Service Fabric explorer. You will see only one container instance running on one node. Now increase the instance count to number of nodes – 1, i.e. 4 and republish. See how quick your container instances scale and start listening for new requests. 

Now disable one of the nodes that hosts a container instance from the cluster. Use Service Fabric explorer to do this, go to the node, click “…” and select “Deactivate (restart)”. Observe how the container instance on this node will be moved to another working node super quick.
##### 1.7.2.	Scaling with adding/removing nodes from the cluster
Begin by setting instance count to -1 for your apps/webapi and republish to Azure. Wait for publish to finish and see your container instance on all nodes. Now manually add new VM to your cluster and observe the changes. When a new VM is successfully attached to your cluster, Service Fabric automatically create new container instance and deploy on the new VM. 

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-concepts-scalability#scaling-by-creating-or-removing-stateless-service-instances  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-scaling  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-tutorial-scale-cluster  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-scale-up-down  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-programmatic-scaling  

#### 1.8.	Add resource constraints for your containers 

When you're running multiple services on the same node or cluster, it's possible that one service might consume more resources, starving other services in the process. This problem is referred to as the "noisy neighbor" problem. Azure Service Fabric enables the developer to specify reservations and limits per service to guarantee resources and limit resource usage.

In this challenge, add resource governance to your containers to run with 0.5 GB and 1 CPU core each.

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-resource-governance  

## Additional Challenges

Pick the challenge of your choice from the below list:

### 2.	SERVICE FABRIC MESH
Azure Service Fabric Mesh is a fully managed service that enables developers to deploy microservices applications without managing virtual machines, storage, or networking. Applications hosted on Service Fabric Mesh run and scale without you worrying about the infrastructure powering it. Service Fabric Mesh consists of clusters of thousands of machines. All cluster operations are hidden from the developer. Simply upload your code and specify resources you need, availability requirements, and resource limits.

Service Fabric Mesh is in public preview as of now and is planned to go General availability next year.

#### 2.1.	Setup your development experience 
You have to setup your development box before you proceed with Service Fabric mesh. Please follow the following links to get the dev setup. 

https://docs.microsoft.com/en-us/azure/service-fabric-mesh/service-fabric-mesh-howto-setup-developer-environment-sdk

https://docs.microsoft.com/en-us/azure/service-fabric-mesh/service-fabric-mesh-howto-setup-cli

Open PowerShell/ command prompt and type “az mesh”. If the command runs successfully then your local box is setup. 
#### 2.2.	Create a new .Net application and deploy on Mesh
You'll learn how to use Visual Studio to create an Azure Service Fabric Mesh app that has an ASP.NET web front-end and an ASP.NET Core Web API back-end service. Then you'll debug the app on your local development cluster. You'll publish the app to Azure and then make config, code changes, and upgrade the app. Finally, you'll clean up unused Azure resources so that you are not charged for what you aren't using.

The resource link below has the direction to source code that you can use to perform the exercise. 

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric-mesh/service-fabric-mesh-tutorial-create-dotnetcore  

### 3.	ADD MONITORING, DIAGNOSTICS FOR YOUR CONTAINERS

Running and operating a distributed system is hard. Without good instrumentation and monitoring it is impossible. To ensure you have a good understanding of how the application is performing and where potential issues may occur, you should add comprehensive monitoring to the solution.

This challenge requires you to add extensive monitoring that covers the following 3 areas:
  * Application Monitoring 
  * Platform/Cluster Monitoring 3
  * Infrastructure/Performance Monitoring

#### 3.1.1.	Application Monitoring: 

Application monitoring is essential to understanding what the application is doing and if anything has gone wrong. When things do go wrong, the telemetry sent by the application is often the first place to look! Currently the application writes logs using each service’s own EventSource. This harnesses the power of ETW on Windows. ETW is rich, extensible and fast. However, without something to forward those logs off the node into a central repository, they’ll be very hard to access and comprehend. This challenge requires that you add application level monitoring that allows you to see what the application is doing, how it is performing and what errors are occurring.

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-diagnostics-overview#application-monitoring  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-diagnostics-event-analysis-appinsights  
https://github.com/Microsoft/ApplicationInsights-aspnetcore/wiki/Getting-Started#add-the-instrumentation-key-to-appsettingsjson  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-diagnostics-event-aggregation-eventflow  
https://github.com/Microsoft/ApplicationInsights-ServiceFabric  
https://blogs.msdn.microsoft.com/softwaresimian/2017/06/16/azureservice-fabric-application-insights-working-sample/  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-tutorial-monitoring-wincontainers  

#### 3.1.2.	Cluster monitoring
When using a distributed platform such as Service Fabric, it is important to ensure you have deep insight into how it is performing and whether you need to take any action to mitigate issues. The Service Fabric agents write logs out to each node, you need to collect all of these into a central location for triage, alerting and analysis.

Some recommended approaches are listed below. 

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-diagnostics-overview#platform-cluster-monitoring  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-diagnostics-oms-setup  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-diagnostics-event-analysis-oms  

#### 3.1.3.	Infrastructure Monitoring
Service Fabric runs on a set of nodes (virtual or physical machines). In Azure deployed clusters this infrastructure layer is provided by Virtual Machine Scale Sets. We want to know how these machines are performing. This information is critical to understanding whether or not we have enough capacity in the cluster to handle our workload. Extracting key metrics such as Performance Counters and OS logs will help us build a holistic picture of the state of our cluster.

This challenge requires you to enable Performance Counters and set an alert for high memory and CPU usage across the cluster.

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-diagnostics-overview#performance-monitoring  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-diagnostics-oms-agent  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-diagnostics-perf-wad  

### 4.	CI/CD PIPELINE 

For you to safely make iterative changes to the application code, it is important that you move from manually deploying updates to an automated system. This challenge requires you to create an automated build, test and deployment pipeline. Once you’ve set it up, all modifications to the application should be pushed through the pipeline and into your cluster.

Your CI should build and test any code changes committed or merged on to your master branch. The build should then publish the build artifacts to a staging area that can be accessed by a release management tool in CD.

Your CD should pick up these build artifacts and execute a release into your cluster leveraging Service Fabric’s rolling update mechanism. You can apply additional items such as gated check ins, notifications and policies if you wish. 

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-tutorial-deploy-container-app-with-cicd-vsts#commit-and-push-changes-trigger-a-release   
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-tutorial-deploy-app-with-cicd-vsts  
https://docs.microsoft.com/en-us/vsts/accounts/create-account-msa-or-work-student?view=vsts  
https://about.gitlab.com  

### 5.	AUTO SCALE CONTAINERS 
<<Naveen>> to add the description, links and solution file. 

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-resource-manager-autoscaling  

### 6.	USING SERVICE FABRIC RELIABLE COLLECTION 

Service Fabric reliable collections enable you to write highly available, scalable, and low-latency cloud applications as though you were writing single computer applications. The classes in the Microsoft.ServiceFabric.Data.Collections namespace provide a set of collections that manage the replication and local state. Your reads are local while writes incur the minimum number of network IOs.

In this exercise, you have an Asp.Net core project in a Service Fabric Reliable stateful application – VotingApp located at  https://github.com/kagowda/India-Hackathon/tree/master/reliablecollections. VotingApp has a frontend web server – VotingWeb and backend server – VotingData. Deploy this app and vote for your favorites. Now kill the VotingData process.

Do you see data loss? Checkout VoteDataController.cs. You will see that we are using a .Net concurrent dictionary to store data.

Your task is to change the code to store data in Reliable Collection. Make your changes. Deploy the app and kill the VotingData process again. Kill it as many times as you want, your data is safe with Reliable Collections.

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-reliable-services-reliable-collections  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-work-with-reliable-collections  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-reliable-services-quick-start#create-a-stateful-service  

### 7.	 CREATE NEW WEB APPLICATION/MICROSERVICES AND DEPLOY TO SERVICE FABRIC

This challenge is your opportunity to get hands on building a new Service Fabric service. You can write this application using whatever framework, language or tooling you wish to. If you choose to use .NET, you can write a new .Net core application and deploy as guest executables or plugin to the Service Fabric Reliable services programming model. This is an open challenge, go wild!

**Resources:**  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-tutorial-create-dotnet-app  
https://docs.microsoft.com/en-us/azure/service-fabric/quickstart-guest-app  
https://azure.microsoft.com/en-us/resources/samples/service-fabric-dotnet-web-reference-app  
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-deploy-existing-app  
