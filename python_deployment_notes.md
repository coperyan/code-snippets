# Useful Python Notes

### Conda Environments

- Creation
  `conda create --name environmentname`
- Creation from .yml file
  `conda env create -f environmentname.yml`
- Creation in specific directory
  `conda create --prefix ./envs --name environmentname`
- Package List in Env
  `conda list -n environmentname`
- Activation
  `conda activate environmentname`
- Deactivation
  `conda deactivate environmentname`

### Package Setup

- Get all Files in one Folder, make sure to add `__init__.py` to the folder as well
- Make sure packages are referencing modules with `.modulename` instead of `modulename`
- Create requirements.txt
  `pipreqs`
- Make sure the parent directory has a file, "pyproject.toml"

```
[build-system]
requires = ["setuptools", "wheel"]
build-backend = "setuptools.build_meta"
```

- Create setup.py with interesting stuff..

```
from setuptools import setup

setup(
    name='baseball_savant',
    description="Python wrapper for Baseball Savant data",
    url="https://github.com/coperyan/baseball_savant/",

    author='Ryan Cope',
    author_email='ryancopedev@gmail.com',

    version='0.0.1',
    packages=['baseball_savant'],
    install_requires=[
        'requests',
        'importlib; python_version == "2.6"',
    ],

    license='MIT',
    keywords = 'baseball savant API',

    classifiers = [
        "Development Status :: 4 - Beta",
        "Intended Audience :: Developers",
        "License :: OSI Approved :: MIT License",
        "Natural Language :: English",
        "Programming Language :: Python :: 2.7",
        "Programming Language :: Python :: 3.5",
    ]
)
```

- Run the following code

```
python -m build
```
