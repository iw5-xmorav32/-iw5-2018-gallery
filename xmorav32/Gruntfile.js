/// <binding AfterBuild='default' ProjectOpened='watch' />
module.exports = function (grunt) {
    grunt.initConfig({
        bower: {
            install: {
                options: {
                    targetDir: "Scripts",
                    layout: "byComponent",
                    cleanTargetDir: false
                }
            }
        },
        less: {
            dev: {
                files: [{
                    src: ['Content/StyleSheet.less'],
                    expand: true,
                    rename: function (dest, src) { return dest + src.replace('.less', '.css') },
                    dest: 'wwwroot/'
                }]
            }
        },
        watch: {
            less: {
                files: "Content/*.less",
                tasks: ["less"]
            }
        }
    });

    grunt.registerTask("default", ["bower:install", "less:dev"]);
    grunt.loadNpmTasks("grunt-bower-task");
    grunt.loadNpmTasks("grunt-contrib-less");
    grunt.loadNpmTasks("grunt-contrib-watch");
};