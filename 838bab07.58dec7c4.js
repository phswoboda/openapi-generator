(window.webpackJsonp=window.webpackJsonp||[]).push([[81],{209:function(e,t,n){"use strict";n.r(t),n.d(t,"frontMatter",(function(){return i})),n.d(t,"metadata",(function(){return c})),n.d(t,"rightToc",(function(){return l})),n.d(t,"default",(function(){return u}));var r=n(1),a=n(9),o=(n(0),n(314)),i={id:"contribute-building",title:"Building the code"},c={id:"contribute-building",title:"Building the code",description:"## Using Maven",source:"@site/../docs/building.md",permalink:"/docs/contribute-building",editUrl:"https://github.com/OpenAPITools/openapi-generator/edit/master/website/../docs/building.md",lastUpdatedBy:"Austin Ziegler",lastUpdatedAt:1664184884,sidebar:"docs",previous:{title:"Code of Conduct",permalink:"/docs/code-of-conduct"},next:{title:"Create a New Generator",permalink:"/docs/new-generator"}},l=[{value:"Using Maven",id:"using-maven",children:[]},{value:"Using Docker",id:"using-docker",children:[{value:"Docker in Vagrant",id:"docker-in-vagrant",children:[]},{value:"Troubleshooting",id:"troubleshooting",children:[]}]}],p={rightToc:l};function u(e){var t=e.components,n=Object(a.a)(e,["components"]);return Object(o.b)("wrapper",Object(r.a)({},p,n,{components:t,mdxType:"MDXLayout"}),Object(o.b)("h2",{id:"using-maven"},"Using Maven"),Object(o.b)("p",null,"To build from source, you need the following installed and available in your ",Object(o.b)("inlineCode",{parentName:"p"},"$PATH:")),Object(o.b)("ul",null,Object(o.b)("li",{parentName:"ul"},Object(o.b)("p",{parentName:"li"},Object(o.b)("a",Object(r.a)({parentName:"p"},{href:"https://java.oracle.com"}),"Java 8"))),Object(o.b)("li",{parentName:"ul"},Object(o.b)("p",{parentName:"li"},Object(o.b)("a",Object(r.a)({parentName:"p"},{href:"https://maven.apache.org/"}),"Apache maven 3.3.4 or greater")))),Object(o.b)("p",null,"After cloning the project, you can build it from source with this command:"),Object(o.b)("pre",null,Object(o.b)("code",Object(r.a)({parentName:"pre"},{className:"language-bash"}),"mvn clean install\n")),Object(o.b)("p",null,"If you don't have maven installed, you may directly use the included ",Object(o.b)("a",Object(r.a)({parentName:"p"},{href:"https://github.com/takari/maven-wrapper"}),"maven wrapper"),", and build with the command:"),Object(o.b)("pre",null,Object(o.b)("code",Object(r.a)({parentName:"pre"},{className:"language-bash"}),"./mvnw clean install\n")),Object(o.b)("h2",{id:"using-docker"},"Using Docker"),Object(o.b)("p",null,"You can use ",Object(o.b)("inlineCode",{parentName:"p"},"run-in-docker.sh")," to do all development. This script maps your local repository to ",Object(o.b)("inlineCode",{parentName:"p"},"/gen"),"\nin the docker container. It also maps ",Object(o.b)("inlineCode",{parentName:"p"},"~/.m2/repository")," to the appropriate container location."),Object(o.b)("p",null,"To execute ",Object(o.b)("inlineCode",{parentName:"p"},"mvn package"),":"),Object(o.b)("pre",null,Object(o.b)("code",Object(r.a)({parentName:"pre"},{className:"language-bash"}),"git clone https://github.com/openapitools/openapi-generator\ncd openapi-generator\n./run-in-docker.sh mvn package\n")),Object(o.b)("p",null,"Build artifacts are now accessible in your working directory."),Object(o.b)("p",null,"Once built, ",Object(o.b)("inlineCode",{parentName:"p"},"run-in-docker.sh")," will act as an executable for openapi-generator-cli. To generate code, you'll need to output to a directory under ",Object(o.b)("inlineCode",{parentName:"p"},"/gen")," (e.g. ",Object(o.b)("inlineCode",{parentName:"p"},"/gen/out"),"). For example:"),Object(o.b)("pre",null,Object(o.b)("code",Object(r.a)({parentName:"pre"},{className:"language-bash"}),"./run-in-docker.sh help # Executes 'help' command for openapi-generator-cli\n./run-in-docker.sh list # Executes 'list' command for openapi-generator-cli\n./run-in-docker.sh /gen/bin/generate-samples.sh /gen/bin/configs/go-petstore.yaml  # Builds the Go client\n./run-in-docker.sh generate -i modules/openapi-generator/src/test/resources/3_0/petstore.yaml \\\n    -g go -o /gen/out/go-petstore -p packageName=petstore # generates go client, outputs locally to ./out/go-petstore\n")),Object(o.b)("h3",{id:"docker-in-vagrant"},"Docker in Vagrant"),Object(o.b)("p",null,"Prerequisite: install ",Object(o.b)("a",Object(r.a)({parentName:"p"},{href:"https://www.vagrantup.com/downloads.html"}),"Vagrant")," and ",Object(o.b)("a",Object(r.a)({parentName:"p"},{href:"https://www.virtualbox.org/wiki/Downloads"}),"VirtualBox"),"."),Object(o.b)("pre",null,Object(o.b)("code",Object(r.a)({parentName:"pre"},{className:"language-bash"}),"git clone https://github.com/openapitools/openapi-generator.git\ncd openapi-generator\nvagrant up\nvagrant ssh\ncd /vagrant\n./run-in-docker.sh mvn package\n")),Object(o.b)("h3",{id:"troubleshooting"},"Troubleshooting"),Object(o.b)("p",null,"If an error like this occurs, just execute the ",Object(o.b)("strong",{parentName:"p"},"mvn clean install -U")," command:"),Object(o.b)("blockquote",null,Object(o.b)("p",{parentName:"blockquote"},"org.apache.maven.lifecycle.LifecycleExecutionException: Failed to execute goal org.apache.maven.plugins:maven-surefire-plugin:2.19.1:test (default-test) on project openapi-generator: A type incompatibility occurred while executing org.apache.maven.plugins:maven-surefire-plugin:2.19.1:test: java.lang.ExceptionInInitializerError cannot be cast to java.io.IOException")),Object(o.b)("pre",null,Object(o.b)("code",Object(r.a)({parentName:"pre"},{className:"language-bash"}),"./run-in-docker.sh mvn clean install -U\n")),Object(o.b)("blockquote",null,Object(o.b)("p",{parentName:"blockquote"},"Failed to execute goal org.fortasoft:gradle-maven-plugin:1.0.8:invoke (default) on project openapi-generator-gradle-plugin-mvn-wrapper: org.gradle.tooling.BuildException: Could not execute build using Gradle distribution '",Object(o.b)("a",Object(r.a)({parentName:"p"},{href:"https://services.gradle.org/distributions/gradle-4.7-bin.zip"}),"https://services.gradle.org/distributions/gradle-4.7-bin.zip"),"'")),Object(o.b)("p",null,"Right now: no solution for this one :|"))}u.isMDXComponent=!0},314:function(e,t,n){"use strict";n.d(t,"a",(function(){return b})),n.d(t,"b",(function(){return g}));var r=n(0),a=n.n(r);function o(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}function i(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function c(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?i(Object(n),!0).forEach((function(t){o(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):i(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function l(e,t){if(null==e)return{};var n,r,a=function(e,t){if(null==e)return{};var n,r,a={},o=Object.keys(e);for(r=0;r<o.length;r++)n=o[r],t.indexOf(n)>=0||(a[n]=e[n]);return a}(e,t);if(Object.getOwnPropertySymbols){var o=Object.getOwnPropertySymbols(e);for(r=0;r<o.length;r++)n=o[r],t.indexOf(n)>=0||Object.prototype.propertyIsEnumerable.call(e,n)&&(a[n]=e[n])}return a}var p=a.a.createContext({}),u=function(e){var t=a.a.useContext(p),n=t;return e&&(n="function"==typeof e?e(t):c({},t,{},e)),n},b=function(e){var t=u(e.components);return a.a.createElement(p.Provider,{value:t},e.children)},s={inlineCode:"code",wrapper:function(e){var t=e.children;return a.a.createElement(a.a.Fragment,{},t)}},d=Object(r.forwardRef)((function(e,t){var n=e.components,r=e.mdxType,o=e.originalType,i=e.parentName,p=l(e,["components","mdxType","originalType","parentName"]),b=u(n),d=r,g=b["".concat(i,".").concat(d)]||b[d]||s[d]||o;return n?a.a.createElement(g,c({ref:t},p,{components:n})):a.a.createElement(g,c({ref:t},p))}));function g(e,t){var n=arguments,r=t&&t.mdxType;if("string"==typeof e||r){var o=n.length,i=new Array(o);i[0]=d;var c={};for(var l in t)hasOwnProperty.call(t,l)&&(c[l]=t[l]);c.originalType=e,c.mdxType="string"==typeof e?e:r,i[1]=c;for(var p=2;p<o;p++)i[p]=n[p];return a.a.createElement.apply(null,i)}return a.a.createElement.apply(null,n)}d.displayName="MDXCreateElement"}}]);